using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
     class Home : WebsiteTemplate
     {
          public string content;

          public override void RenderBody()
          {
               content = @"
                                                  <hr />
                                        <div class='container'>
                                             <div class='row' >
                                                  <div class='col-sm'>
                                                       <center>
                                                            <img src = '~/Content/Images/Info/@item.picture.Path'  class='img-thumbnail' width='500px'
                                                                 alt='@Html.DisplayFor(modelItem => item.Title)' style='border-radius:30px;' />
                                                       </center>
                                                       <h2 style = 'color:red' >< center > @Html.DisplayFor(modelItem => item.Title) </ center ></ h2 >
                                                  </div>
                                             </ div >

                                             < div class='row'>
                                                  <div class='col-sm'>
                                                       <p style='color:blue'> @Html.DisplayFor(modelItem => item.Content) </p>
                                                  </ div>
                                             </ div>
                                        </ div>
                                   <hr/>";

               Console.WriteLine(content);
          }
     }
}
