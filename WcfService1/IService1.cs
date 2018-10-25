using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {       
        [OperationContract]
        [WebInvoke(Method ="POST", UriTemplate ="/AddTrainee", RequestFormat =WebMessageFormat.Json, BodyStyle =WebMessageBodyStyle.Wrapped, ResponseFormat =WebMessageFormat.Json)]
        string PostTrainee(Trainee sampleTrainee);

        // TODO: Add your service operations here
    }
    
    [DataContract]
    public class Trainee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Designation { get; set; }
    }
}
