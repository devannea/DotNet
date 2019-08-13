using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public static class AuthorMappingExtensions
    {

        public static AuthorModel ToApiModel(this Author author)
        {
            // return a new AuthorModel and copy the
             // property values from the Author domain model
             return new AuthorModel
             {
                 Id = author.Id,
                 BirthDate = author.BirthDate,
                 FirstName = author.FirstName,
                 LastName = author.LastName,
             };
        }

        public static Author ToDomainModel(this AuthorModel authorModel)
        {
            // return a new Author domain model and copy the
             // property values over from the AuthorModel
             return new Author
             {
                 Id = authorModel.Id,
                 BirthDate = authorModel.BirthDate,
                 FirstName = authorModel.FirstName,
                 LastName = authorModel.LastName,
             };
        }

        public static IEnumerable<AuthorModel> ToApiModels(this IEnumerable<Author> authors)
        {
            return authors.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Author> ToDomainModel(this IEnumerable<AuthorModel> authorModels)
        {
            return authorModels.Select(a => a.ToDomainModel());
        }
    }
}
