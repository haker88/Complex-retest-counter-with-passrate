using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable aa = new DataTable(); aa.Columns.Add("ISN", typeof(Int32)); aa.Columns.Add("Result", typeof(Int32)); aa.Columns.Add("Lift", typeof(Int32));
            DataTable bb = new DataTable(); bb.Columns.Add("ISN", typeof(Int32)); bb.Columns.Add("Count", typeof(Int32)); bb.Columns.Add("Result", typeof(Int32));
            aa.Rows.Add(123, 1, 0);
            aa.Rows.Add(122, 1, 0);
            aa.Rows.Add(124, 0, 0);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 0);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(123, 1, 1);
            aa.Rows.Add(123, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(122, 0, 0);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(123, 1, 1);
            aa.Rows.Add(123, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 0);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(123, 1, 1);
            aa.Rows.Add(123, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 0);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(123, 1, 1);
            aa.Rows.Add(123, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(122, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(122, 0, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 1, 1);
            aa.Rows.Add(124, 0, 1);
            aa.Rows.Add(124, 1, 1);
            
            dataGridView1.DataSource = aa;
            //ITERATE
            int isn = 0; int result = 0; int count = 0; int lift = 0; 
            for (int i = 0; i < aa.Rows.Count-1; i++)
            {   lift = int.Parse(aa.Rows[i][2].ToString());
                if (0 == lift) //check for gauges, press detected
                { isn = int.Parse(aa.Rows[i][0].ToString()); 

                    for (int j = i + 1; j < aa.Rows.Count; j++) //go through again to check all lines against gauge
                    {   int isn2 = int.Parse(aa.Rows[j][0].ToString()); //current isn
                        int lift2 = int.Parse(aa.Rows[j][2].ToString()); //current lift

                        if ((isn == isn2) && (lift2 == 1)) //gauge found 
                        { count++; result = int.Parse(aa.Rows[j][1].ToString()); continue;  } //add count, current result
                        else {
                            if (isn != isn2) { continue; } //different isn, next iteration
                            else { if ((isn == isn2) && (lift2 != 1)) { break; count = 0; } //PRESS FOUND !!!, exit loop

                            }

                        }

                    }
                    if (count > 1)
                    { bb.Rows.Add(isn, count, result); count = 0; }
                        


                }
                else { continue; } //no press, next row

                                        


            }
            dataGridView2.DataSource = bb;
            DataTable cc = new DataTable(); cc.Columns.Add("Count", typeof(Int32)); cc.Columns.Add("Passrate%", typeof(Double));
            int attemptbb;  
            for (int i = 1; i < 20; i++)
            {   int result1 = 0; double sum = 0; double count1 = 0;
                for (int j = 0; j < bb.Rows.Count - 1; j++)
                {   attemptbb = int.Parse(bb.Rows[j][1].ToString());
                    result1 = int.Parse(bb.Rows[j][2].ToString());
                    if (i == attemptbb)
                    {  count1++; sum += result1;
                         } else { continue; }
                }

                if ((count1 > 0) & (sum>0))
                {
                    double passrate = sum / count1;
                    if (passrate > 0)
                    {
                        double round = Math.Round(passrate, 2)*100;
                        
                        cc.Rows.Add(i, round);
                    }
                    else { cc.Rows.Add(i, 0); }
                    
                }
                else { cc.Rows.Add(i, 0); }
                dataGridView3.DataSource = cc;
                

            }

















        }
    }
}
