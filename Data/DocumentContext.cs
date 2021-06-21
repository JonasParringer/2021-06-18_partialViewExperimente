using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2021_06_18_partialViewExperimente.Models;

    public class DocumentContext : DbContext
    {
        public DocumentContext (DbContextOptions<DocumentContext> options)
            : base(options)
        {
        }

        public DbSet<_2021_06_18_partialViewExperimente.Models.Document> Document { get; set; }
    }
