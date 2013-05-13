﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecNote.Entities.Projects
{
    public class Project : Base
    {
        /// <summary>
        /// Name of project
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Indicate if this project is only a temporal project in edition
        /// </summary>
        public bool IsTemporal { get; set; }

        /// <summary>
        /// User owner of this project
        /// </summary>
        public Users.User Owner { get; set; }

        /// <summary>
        /// Actors on this project
        /// </summary>
        public Actor[] Actors { get; set; }
    }
}