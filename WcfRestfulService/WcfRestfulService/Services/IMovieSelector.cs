using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfRestfulService.DataContracts;

namespace WcfRestfulService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMovieSelector" in both code and config file together.
    [ServiceContract]
    public interface IMovieSelector
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "MovieSelector/")]
        Movie SelectMovie();
    }
}
