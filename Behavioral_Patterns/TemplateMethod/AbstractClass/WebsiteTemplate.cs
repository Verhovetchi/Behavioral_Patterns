using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
     public abstract class WebsiteTemplate
     {
          private string _header = 
               @"<!DOCTYPE html>
               <html>
                    <head>
                         <meta charset='utf-8'/>
                         <title>MyPage</title>
                    </head>
                    <body>
                         <header>
                              Header
                         </header>
                         <article>";

          private string _footer = @"
                         </article>
                         <footer>
                              Footer
                         </footer>
                    </body>
               </html>";
                                  
          
          public void ShowPage()
          {
               Console.WriteLine(_header);
               RenderBody();
               Console.WriteLine(_footer);
          }

          public abstract void RenderBody();
     }
}
