﻿// Copyright (c) 2020 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.Collections.Generic;
using BookApp.ServiceLayer.DefaultSql.Books.QueryObjects;

namespace BookApp.ServiceLayer.DefaultSql.Books
{
    public interface IBookFilterDropdownService
    {
        /// <summary>
        ///     This makes the various Value + text to go in the dropdown based on the FilterBy option
        /// </summary>
        /// <param name="filterBy"></param>
        /// <returns></returns>
        IEnumerable<DropdownTuple> GetFilterDropDownValues(BooksFilterBy filterBy);
    }
}