using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication2
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            ServiceReference1.LanguageServiceClient ws = new ServiceReference1.LanguageServiceClient();
            ORAWSVService.ORAWSVPortTypeClient oraws = new ORAWSVService.ORAWSVPortTypeClient();
            

            oraws.XMLFromQueryCompleted +=new EventHandler<ORAWSVService.XMLFromQueryCompletedEventArgs>(oraws_XMLFromQueryCompleted);


            ORAWSVService.query qry = new ORAWSVService.query();
            ORAWSVService.queryQuery_text qry_text = new ORAWSVService.queryQuery_text();
            
            qry_text.type = ORAWSVService.queryQuery_textType.SQL;
            qry_text.Value = "SELECT * FROM dual;";
            
            qry.query_text = qry_text;
            qry.pretty_print = false;

            SilverlightApplication2.ORAWSVService.XMLFromQueryRequest qr = new ORAWSVService.XMLFromQueryRequest(qry);
            //qr.query

            //oraws.XMLFromQueryAsync(qry);
        }

        protected void oraws_XMLFromQueryCompleted(Object sender, ORAWSVService.XMLFromQueryCompletedEventArgs e)
        {

            if (e.Error == null)
            {

                object objRetorno = e.Result;

            }

        }

         


    }
}
