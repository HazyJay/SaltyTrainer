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
        public DbControl(SQLiteConnection sql_con)
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;

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
                        command = String.Format("UPDATE MatchHistoryDataByChar SET TotalGames = TotalGames + 1 WHERE CharName = '{0}'", fighterA);
                        ExecuteQuery(command);
                        command = String.Format("UPDATE MatchHistoryDataByChar SET TotalGames = TotalGames + 1 WHERE CharName = '{0}'", fighterB);
                        ExecuteQuery(command);
                        //stat averaging
                        oldAtier = Convert.ToDouble(GetValue("AvgTier", fighterA));
                        oldBtier = Convert.ToDouble(GetValue("AvgTier", fighterB));

                        oldAodds = Convert.ToDouble(GetValue("AvgOdds", fighterA));
                        oldBodds = Convert.ToDouble(GetValue("AvgOdds", fighterB));
                        
                        Agames = Convert.ToInt32(GetValue("TotalGames", fighterA));
                        Bgames = Convert.ToInt32(GetValue("TotalGames", fighterB));

                        newAodds = (((oldAodds) * (Agames - 1)) + aOdds) / Agames;
                        newBodds = (((oldBodds) * (Bgames - 1)) + bOdds) / Bgames;

                        newAtier = (((oldAtier) * (Agames - 1)) + tier) / Agames;
                        newBtier = (((oldBtier) * (Bgames - 1)) + tier) / Bgames;

                        command = String.Format("UPDATE MatchHistoryDataByChar SET AvgOdds = {0} WHERE CharName = '{1}'", newAodds, fighterA);
                        ExecuteQuery(command);
                        command = String.Format("UPDATE MatchHistoryDataByChar SET AvgOdds = {0} WHERE CharName = '{1}'", newBodds, fighterB);
                        ExecuteQuery(command);

                        command = String.Format("UPDATE MatchHistoryDataByChar SET AvgTier = {0} WHERE CharName = '{1}'", newAtier, fighterA);
                        ExecuteQuery(command);
                        command = String.Format("UPDATE MatchHistoryDataByChar SET AvgTier = {0} WHERE CharName = '{1}'", newBtier, fighterB);
                        ExecuteQuery(command);
                        //give correct chars wins and losses
                        if (winner)
                        {
                            command = String.Format("UPDATE MatchHistoryDataByChar SET Tier{0}Wins = Tier{0}Wins + 1 WHERE CharName = '{1}'", tier, fighterA);
                            ExecuteQuery(command);
                            command = String.Format("UPDATE MatchHistoryDataByChar SET Tier{0}Losses = Tier{0}Losses + 1 WHERE CharName = '{1}'", tier, fighterB);
                            ExecuteQuery(command);
                        }
                        else
                        {
                            command = String.Format("UPDATE MatchHistoryDataByChar SET Tier{0}Wins = Tier{0}Wins + 1 WHERE CharName = '{1}'", tier, fighterB);
                            ExecuteQuery(command);
                            command = String.Format("UPDATE MatchHistoryDataByChar SET Tier{0}Losses = Tier{0}Losses + 1 WHERE CharName = '{1}'", tier, fighterA);
                            ExecuteQuery(command);
                        }

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
    }
}
