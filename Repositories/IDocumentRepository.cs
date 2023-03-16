using DataAcess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IDocumentRepository
    {
        List<DocumentDTO> GetDocs(int id);
        DocumentDTO GetDocument(int id);
        List<DocumentDTO> GetDocuments();
        void Add(DocumentDTO documentDTO);
        void Update(DocumentDTO documentDTO);
        void Delete(int id);
    }
}
