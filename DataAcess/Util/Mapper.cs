using BusinessObjects.Models;
using DataAcess.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Util
{
    public class Mapper
    {
        public static DTO.DocumentDTO mapToDTO(Document document)
        {
            if (document != null)
            {
                DTO.DocumentDTO memberDTO = new DTO.DocumentDTO
                {
                    Id = document.Id,
                    Name = document.Name,
                    NumberOfQuiz = document.NumberOfQuiz,
                    AuthorID = document.AuthorID,
                    DataCreate = document.DataCreate
                };
                return memberDTO;
            }
            else
            {
                return null;
            }

        }

        public static QuizDTO mapToDTO(Quiz quiz)
        {
            if (quiz != null)
            {
                QuizDTO quizDTO = new QuizDTO
                {
                    QuizId = quiz.QuizId,
                    UserId = quiz.UserId,
                    SubjectId = quiz.SubjectId,
                    QuizName = quiz.QuizName,
                    DataCreate = quiz.DataCreate,
                    NumberOfQuestion = quiz.NumberOfQuestion,

                };
                return quizDTO;
            }
            else
            {
                return null;
            }

        }

        public static SubjectDTO mapToDTO(Subject subject)
        {
            if (subject != null)
            {
                SubjectDTO subjectDTO = new SubjectDTO
                {
                    SubjectId = subject.SubjectId,
                    UserId = subject.UserId,
                    NumberOfQuiz = subject.NumberOfQuiz,
                    SubjectName= subject.SubjectName,
                    DataCreate= subject.DataCreate,
                    DocumentId = subject.DocumentId,
                };
                return subjectDTO;
            }
            else
            {
                return null;
            }

        }

        public static UserDTO mapToDTO(User user)
        {
            if (user != null)
            {
                UserDTO userDTO = new UserDTO
                {
                    email = user.email,
                    userId = user.userId,
                    password = user.password
                };
                return userDTO;
            }
            else
            {
                return null;
            }

        }

        public static UserInformationDTO mapToDTO(UserInformation userInformation)
        {
            if (userInformation != null)
            {
                UserInformationDTO userInformationDTO = new UserInformationDTO
                {
                    Id = userInformation.Id,
                    Name = userInformation.Name,
                    School = userInformation.School,
                    LearningHour = userInformation.LearningHour,
                    AVG = userInformation.AVG,
                    UserId = userInformation.UserId
                };
                return userInformationDTO;
            }
            else
            {
                return null;
            }

        }

        public static UserLearningDTO mapToDTO(UserLearning userLearning)
        {
            if (userLearning != null)
            {
                UserLearningDTO userLearningDTO = new UserLearningDTO
                {
                    UserId = userLearning.UserId,
                    SubjectId = userLearning.SubjectId,
                    Id = userLearning.Id,
                };
                return userLearningDTO;
            }
            else
            {
                return null;
            }

        }

        public static Document mapToEntity(DTO.DocumentDTO documentDTO)
        {
            if (documentDTO != null)
            {
                Document member = new Document
                {
                    Id = documentDTO.Id,
                    Name = documentDTO.Name,
                    NumberOfQuiz = documentDTO.NumberOfQuiz,
                    AuthorID = documentDTO.AuthorID,
                    DataCreate = documentDTO.DataCreate
                };
                return member;
            }
            else
            {
                return null;
            }

        }

        public static Quiz mapToEntity(QuizDTO quizDTO)
        {
            if (quizDTO != null)
            {
                Quiz quiz = new Quiz
                {
                    QuizId = quizDTO.QuizId,
                    UserId = quizDTO.UserId,
                    SubjectId = quizDTO.SubjectId,
                    QuizName = quizDTO.QuizName,
                    DataCreate = quizDTO.DataCreate,
                    NumberOfQuestion = quizDTO.NumberOfQuestion
                };
                return quiz;
            }
            else
            {
                return null;
            }

        }

        public static Subject mapToEntity(SubjectDTO subjectDTO)
        {
            if (subjectDTO != null)
            {
                Subject subject = new Subject
                {
                    SubjectId = subjectDTO.SubjectId,
                    UserId = subjectDTO.UserId,
                    NumberOfQuiz = subjectDTO.NumberOfQuiz,
                    DataCreate= subjectDTO.DataCreate,
                    SubjectName= subjectDTO.SubjectName,
                    DocumentId= subjectDTO.DocumentId,
                };
                return subject;
            }
            else
            {
                return null;
            }

        }

        public static User mapToEntity(UserDTO userDTO)
        {
            if (userDTO != null)
            {
                User user = new User
                {
                    email = userDTO.email,
                    userId = userDTO.userId,
                    password = userDTO.password
                };
                return user;
            }
            else
            {
                return null;
            }

        }

        public static UserInformation mapToEntity(UserInformationDTO userInformationDTO)
        {
            if (userInformationDTO != null)
            {
                UserInformation userInformation = new UserInformation
                {
                    Id = userInformationDTO.Id,
                    Name = userInformationDTO.Name,
                    School = userInformationDTO.School,
                    LearningHour = userInformationDTO.LearningHour,
                    AVG = userInformationDTO.AVG,
                    UserId = userInformationDTO.UserId
                };
                return userInformation;
            }
            else
            {
                return null;
            }

        }

        public static UserLearning mapToEntity(UserLearningDTO userLearningDTO)
        {
            if (userLearningDTO != null)
            {
                UserLearning userLearning = new UserLearning
                {
                    UserId = userLearningDTO.UserId,
                    SubjectId = userLearningDTO.SubjectId,
                    Id = userLearningDTO.Id,
                };
                return userLearning;
            }
            else
            {
                return null;
            }

        }
    }
}
