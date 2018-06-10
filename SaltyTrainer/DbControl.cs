using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlTypes;
using System.Data.SQLite;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class DbControl : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;

        public DbControl(SQLiteConnection ConnPass)
        {
            InitializeComponent();
            sql_con = ConnPass;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader In = new System.IO.StreamReader(@FilePath.Text);
            string line = In.ReadLine();

            string fighterA;
            string fighterB;
            int tier;
            double oldAtier;
            double oldBtier;
            double newAtier;
            double newBtier;
            double A;
            double B;
            double oldAodds;
            double oldBodds;
            double newAodds;
            double newBodds;
            double aOdds;
            double bOdds;
            bool winner;
            bool goodread = true;
            int Agames;
            int Bgames;
            int aStreak;
            int bStreak;
            int aID;
            int bID;

            SQLiteDataReader Reader;

            while (line != "")
            {
                goodread = true;
                string[] tokens = line.Split(',');
                line = In.ReadLine();
                if (tokens[6] == "m")
                {
                    //parse lines into values
                    //fighterA, fighterB, REsult of match, useless, uselsess, Match tier, match type, odds, useless, useless, useless
                    fighterA = tokens[0];
                    fighterB = tokens[1];
                    string[] AB = tokens[7].Split(':');
                    A = Convert.ToDouble(AB[0]);
                    B = Convert.ToDouble(AB[1]);
                    aOdds = A / B;
                    bOdds = B / A;
                    if(tokens[2]=="0")
                    {
                        winner = false;
                    }
                    else
                    {
                        winner = true;
                    }
                    switch(tokens[5])
                    {
                        case "X":
                            tier = 5;
                            break;
                        case "S":
                            tier = 4;
                            break;
                        case "A":
                            tier = 3;
                            break;
                        case "B":
                            tier = 2;
                            break;
                        case "P":
                            tier = 1;
                            break;
                        default:
                            tier = 0;
                            goodread = false;
                            break;
                    }
                    if(goodread)
                    {
                        //sanitization of illegal chars from character names
                        
                        fighterA = fighterA.Replace("'", "");
                        fighterB = fighterB.Replace("'", "");
                        //things to be done for either win or loss
                        string command = String.Format("INSERT OR IGNORE INTO MatchHistoryDataByChar(CharName) Values('{0}')", fighterA);
                        ExecuteQuery(command);
                        command = String.Format("INSERT OR IGNORE INTO MatchHistoryDataByChar(CharName) Values('{0}')", fighterB);
                        ExecuteQuery(command);
                        //stat averaging

                        //retrieval of multiple vals should really be some kind of function. V lazy at the moment. maybe return array of objects? does mismatched type matter?
                        sql_cmd = sql_con.CreateCommand();
                        sql_cmd.CommandText = String.Format("select AvgOdds, AvgTier, TotalGames, WLStreak, CharID FROM MatchHistoryDataByChar WHERE CharName = '{0}'", fighterA);
                        Reader = sql_cmd.ExecuteReader();
                        Reader.Read();

                        oldAodds = Convert.ToDouble(Reader[0]);
                        oldAtier = Convert.ToDouble(Reader[1]);
                        Agames = Convert.ToInt32(Reader[2]);
                        aStreak = Convert.ToInt32(Reader[3]);
                        aID = Convert.ToInt32(Reader[4]);

                        sql_cmd = sql_con.CreateCommand();
                        sql_cmd.CommandText = String.Format("select AvgOdds, AvgTier, TotalGames, WLStreak, CharID FROM MatchHistoryDataByChar WHERE CharName = '{0}'", fighterB);
                        Reader = sql_cmd.ExecuteReader();
                        Reader.Read();

                        oldBodds = Convert.ToDouble(Reader[0]);
                        oldBtier = Convert.ToDouble(Reader[1]);
                        Bgames = Convert.ToInt32(Reader[2]);
                        bStreak = Convert.ToInt32(Reader[3]);
                        bID = Convert.ToInt32(Reader[4]);

                        /*oldAtier = Convert.ToDouble(GetValue("AvgTier", fighterA));
                        oldBtier = Convert.ToDouble(GetValue("AvgTier", fighterB));

                        oldAodds = Convert.ToDouble(GetValue("AvgOdds", fighterA));
                        oldBodds = Convert.ToDouble(GetValue("AvgOdds", fighterB));
                        
                        Agames = Convert.ToInt32(GetValue("TotalGames", fighterA));
                        Bgames = Convert.ToInt32(GetValue("TotalGames", fighterB));
                        
                        aStreak = Convert.ToInt32(GetValue("WLStreak", fighterA));
                        bStreak = Convert.ToInt32(GetValue("WLStreak", fighterB));*/

                        newAodds = (((oldAodds) * (Agames)) + aOdds) / (Agames + 1);
                        newBodds = (((oldBodds) * (Bgames)) + bOdds) / (Bgames + 1);

                        newAtier = (((oldAtier) * (Agames)) + tier) / (Agames + 1);
                        newBtier = (((oldBtier) * (Bgames)) + tier) / (Bgames + 1);
                        
                        //strings to build SQLite command for win/loss
                        string AWL;
                        string BWL;
                        //give correct chars wins and losses

                        if (winner)
                        {
                            AWL = "Wins";
                            BWL = "Losses";
                            CreateOrUpdateMatchTable(true, aOdds, bID, aID);
                            CreateOrUpdateMatchTable(false, bOdds, aID, bID);
                            /*command = String.Format("UPDATE MatchHistoryDataByChar SET Tier{0}Wins = Tier{0}Wins + 1 WHERE CharName = '{1}'", tier, fighterA);
                            ExecuteQuery(command);
                            command = String.Format("UPDATE MatchHistoryDataByChar SET Tier{0}Losses = Tier{0}Losses + 1 WHERE CharName = '{1}'", tier, fighterB);
                            ExecuteQuery(command);*/
                        }
                        else
                        {
                            BWL = "Wins";
                            AWL = "Losses";
                            CreateOrUpdateMatchTable(false, aOdds, bID, aID);
                            CreateOrUpdateMatchTable(true, bOdds, aID, bID);
                            /*command = String.Format("UPDATE MatchHistoryDataByChar SET Tier{0}Wins = Tier{0}Wins + 1 WHERE CharName = '{1}'", tier, fighterB);
                            ExecuteQuery(command);
                            command = String.Format("UPDATE MatchHistoryDataByChar SET Tier{0}Losses = Tier{0}Losses + 1 WHERE CharName = '{1}'", tier, fighterA);
                            ExecuteQuery(command);*/
                        }

                        command = String.Format("UPDATE MatchHistoryDataByChar SET AvgOdds = {0}, AvgTier = {1}, Tier{2}{3} = Tier{2}{3} + 1, TotalGames = TotalGames + 1 WHERE CharName = '{4}'", newAodds, newAtier, tier, AWL, fighterA);
                        ExecuteQuery(command);
                        command = String.Format("UPDATE MatchHistoryDataByChar SET AvgOdds = {0}, AvgTier = {1}, Tier{2}{3} = Tier{2}{3} + 1, TotalGames = TotalGames + 1 WHERE CharName = '{4}'", newBodds, newBtier, tier, BWL, fighterB);
                        ExecuteQuery(command);
                        
                        //modify win loss tables for the chars

                    }
                }
            }
        }

        private void ExecuteQuery(string txtQuery)
        {
            //SetConnection();
            //sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            //sql_con.Close();
        }

        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source =MatchHistory.s3db;Version=3;");
        }

        private object GetValue(string val, string character)
        {
            //SetConnection();
            //sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = String.Format("select {0} FROM MatchHistoryDataByChar WHERE CharName = '{1}'",val,character);
            object returnVal = sql_cmd.ExecuteScalar();
            return returnVal;
        }
        

        private void CreateOrUpdateMatchTable(bool WL, double newOdds,  int OpponentID, int CharID)   //creates entry for opponent in specified char's table if it does not exist
        {                                                                                                   //also adds one match between them, and updates W/L record for chars, 
            //SetConnection();
            //sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = String.Format(@"
    CREATE TABLE IF NOT EXISTS CharWinTable{0} (
    OppID   INTEGER PRIMARY KEY
                    REFERENCES MatchHistoryDataByChar (CharID) ON DELETE CASCADE
                                                               ON UPDATE CASCADE
                    UNIQUE
                    NOT NULL,
    WinsVs  INTEGER DEFAULT (0) 
                    NOT NULL,
    LossVs  INTEGER NOT NULL
                    DEFAULT (0),
    GamesVs INTEGER NOT NULL
                    DEFAULT (0),
    OddsVs  DOUBLE  NOT NULL
                    DEFAULT (0) 
); ", CharID);
            //sql_cmd.CommandText = sql_cmd.CommandText.Replace(Environment.NewLine, ""); //remove new lines from sql command if it breaks?
            sql_cmd.ExecuteNonQuery();
            string WLCol;
            if(WL)
            {
                WLCol = "Wins";
            }
            else
            {
                WLCol = "Loss";
            }


            sql_cmd.CommandText = String.Format("INSERT OR IGNORE INTO CharWinTable{0}(OppID) Values('{1}')", CharID,OpponentID);
            sql_cmd.ExecuteNonQuery();

            double oldOdds;
            int numGames;

            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = String.Format("select OddsVs, GamesVs FROM CharWinTable{0} WHERE OppID = '{1}'", CharID,OpponentID);
            SQLiteDataReader Reader = sql_cmd.ExecuteReader();
            Reader.Read();
            oldOdds = Convert.ToDouble(Reader[0]);
            numGames = Convert.ToInt32(Reader[1]);
            Reader.Close();

            newOdds = (((oldOdds) * (numGames)) + newOdds) / (numGames + 1);

            sql_cmd.CommandText = String.Format("UPDATE CharWinTable{0} SET {1}Vs = {1}Vs + 1, GamesVs = GamesVs + 1, OddsVs = {2} WHERE OppID = {3}",CharID,WLCol,newOdds,OpponentID);
            sql_cmd.ExecuteNonQuery();

            Reader.Close();
        }
    }
}
