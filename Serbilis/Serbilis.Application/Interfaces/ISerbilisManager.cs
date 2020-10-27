using Serbilis.Core.Models;
using System.Collections.Generic;

namespace Serbilis.Application.Interfaces
{
    public interface ISerbilisManager
    {
        IEnumerable<RequestPurposeModel> GetRequestPurposeModel();

        string InsertRequesterDetail(RequesterDetailModel requesterModel);

        string InsertRequestDetail(RequestDetailModel requestModel);

    }
}
