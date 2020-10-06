using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    class Model1
    {
        public static void Config(bool v, DataGridView dg, Button[] l)
        {             //Grid-ul nu permite actualizari     
            dg.AllowUserToAddRows = !v;
            dg.AllowUserToDeleteRows = !v;
            dg.ReadOnly = v;
            //btnActualizare disponibil     
            l[0].Enabled = v;
            //btnSalvare si btnRenuntare invizibile       
            l[1].Visible = !v;
            l[2].Visible = !v;
        }
         public static void trateazaEroare(Exception e) 
         {      
             string s = e.Message;    
             //MessageBox.Show(s);    
             if (s.IndexOf("duplicate values") > 0) 
                 MessageBox.Show("Inregistrare deja existenta !");      
             else if (s.IndexOf("cannot be deleted") > 0)         
                 MessageBox.Show("Ati sters inregistrari referite in alte tabele !");   
         }
         public static bool confirmare()
         {
             const string mesaj = "Confirmati stergerea"; 
             const string titlu = "Stergere inregistrare"; 
             DialogResult rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if (rezultat == DialogResult.No) return false; 
             else return true; 
         }
 
    }
}
