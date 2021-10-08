using System;
using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace Terradue.WebService.Model {

    [Route("/one/user/{id}", "GET", Summary = "GET the user", Notes = "User is found from id")]
    [Route("/one/{providerId}/user/{id}", "GET", Summary = "GET the user", Notes = "User is found from id")]
    public class GetOneUser : IReturn<WebOneUser> {
        [ApiMember(Name = "id", Description = "User id", ParameterType = "query", DataType = "int", IsRequired = true)]
        public int Id { get; set; }
        [ApiMember(Name = "providerId", Description = "Provider id", ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ProviderId { get; set; }
    }

    [Route("/one/user/current", "GET", Summary = "GET the current user", Notes = "User is the current user")]
    [Route("/one/{providerId}/user/current", "GET", Summary = "GET the current user", Notes = "User is the current user")]
    public class GetOneCurrentUser : IReturn<WebOneUser> {
        [ApiMember(Name = "providerId", Description = "Provider id", ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ProviderId { get; set; }
    }

    [Route("/one/user", "GET", Summary = "GET a list of users", Notes = "Users can be filtered by Group")]
    [Route("/one/{providerId}/user", "GET", Summary = "GET a list of users", Notes = "Users can be filtered by Group")]
    public class GetOneUsers : IReturn<List<WebOneUser>> {
        [ApiMember(Name = "Group", Description = "Group Name", ParameterType = "path", DataType = "String", IsRequired = false)]
        public String Group { get; set; }
        [ApiMember(Name = "providerId", Description = "Provider id", ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ProviderId { get; set; }
    }

    [Route("/one/user", "PUT", Summary = "Update user password", Notes = "User is contained in the PUT data.")]
    [Route("/one/{providerId}/user", "PUT", Summary = "Update user password", Notes = "User is contained in the PUT data.")]
    public class UpdateOneUser : WebOneUser, IReturn<WebOneUser> {
        [ApiMember(Name = "providerId", Description = "Provider id", ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ProviderId { get; set; }
    }

    [Route("/one/user", "POST", Summary = "Create a new user", Notes = "User is contained in the POST data.")]
    [Route("/one/{providerId}/user", "POST", Summary = "Create a new user", Notes = "User is contained in the POST data.")]
    public class CreateOneUser : WebOneUser, IReturn<WebOneUser> {
        [ApiMember(Name = "providerId", Description = "Provider id", ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ProviderId { get; set; }
    }

    [Route("/one/user/{id}", "DELETE", Summary = "Remove user", Notes = "User is found via Id")]
    [Route("/one/{providerId}/user/{id}", "DELETE", Summary = "Remove user", Notes = "User is found via Id")]
    public class DeleteOneUser : IReturn<WebOneUser> {
        [ApiMember(Name = "id", Description = "User id", ParameterType = "query", DataType = "int", IsRequired = true)]
        public int Id { get; set; }
        [ApiMember(Name = "providerId", Description = "Provider id", ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ProviderId { get; set; }
    }

    //-------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------

    /// <summary>
    /// User.
    /// </summary>
    public class WebOneUser {

        [ApiMember(Name = "Id", Description = "One User Id", ParameterType = "query", DataType = "String", IsRequired = false)]
        public String Id { get; set; }

        [ApiMember(Name = "Name", Description = "One User name", ParameterType = "query", DataType = "String", IsRequired = false)]
        public String Name { get; set; }

        [ApiMember(Name = "AuthDriver", Description = "One User auth driver", ParameterType = "query", DataType = "String", IsRequired = false)]
        public String AuthDriver { get; set; }

        [ApiMember(Name = "Template", Description = "One User template", ParameterType = "query", DataType = "String", IsRequired = false)]
        public String Template { get; set; }

        [ApiMember(Name = "Password", Description = "One User password", ParameterType = "query", DataType = "String", IsRequired = false)]
        public String Password { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Terradue.Metadata.Model.User"/> class.
        /// </summary>
        public WebOneUser() {}

    }
}

