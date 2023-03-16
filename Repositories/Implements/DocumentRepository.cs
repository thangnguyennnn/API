using DataAcess;
using DataAcess.DTO;
using DataAcess.Util;

namespace Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        DocumentDAO documentDAO = new DocumentDAO();

        public void Add(DocumentDTO documentDTO)
        {
            documentDAO.Add(Mapper.mapToEntity(documentDTO));
        }

        public void Delete(int id)
        {
            documentDAO.DeleteDocument(id);
        }

        public List<DocumentDTO> GetDocs(int id)
        {
            return documentDAO.GetDocs(id).Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public List<DocumentDTO> GetDocuments()
        {
            return documentDAO.GetDocuments().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void Update(DocumentDTO DocumentDTO)
        {
            documentDAO.Update(Mapper.mapToEntity(DocumentDTO));
        }

        public DocumentDTO GetDocument(int id)
        {
            return Mapper.mapToDTO(documentDAO.GetDocument(id));
        }
    }
}
