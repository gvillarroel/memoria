﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Driver.Linq;

namespace RecNote.Data.MongoDB.Projects
{
    public class ProjectData : DataBase<Entities.Projects.Project>, Data.Projects.IProjectData
    {
        public Entities.Projects.Project GetTemporalProject(Entities.Users.User User)
        {
            return (
                from e in this.GetCollection().AsQueryable()
                        where e.Object.Owner.ID == User.ID
                        && e.Object.IsTemporal
                    select e
             ).FirstOrDefault();
        }
        public IList<Entities.Projects.Project> GetList()
        {
            return (
                from e in this.GetCollection().AsQueryable()
                where !e.Object.IsTemporal
                select (Entities.Projects.Project)e
                ).ToList();
        }
    }
}