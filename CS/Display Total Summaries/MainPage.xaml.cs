﻿using System;
using System.Collections.Generic;
using System.Windows.Controls;
using DevExpress.Data;
using DevExpress.Xpf.Data;
using DevExpress.Xpf.Grid;

namespace Display_Total_Summaries {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = new AccountList().GetData();
        }
        private void CreateTotalSummaries() {
            grid.TotalSummary.Add(new GridSummaryItem()
            {
                FieldName = "UserName",
                SummaryType = SummaryItemType.Count,
                DisplayFormat = "Total Users: {0}"
            });
            grid.TotalSummary.Add(new GridSummaryItem()
            {
                FieldName = "Age",
                SummaryType = SummaryItemType.Min
            });
            grid.TotalSummary.Add(new GridSummaryItem()
            {
                FieldName = "Age",
                SummaryType = SummaryItemType.Max
            });
        }
        public class AccountList {
            public List<Account> GetData() {
                return CreateAccounts();
            }
            private List<Account> CreateAccounts() {
                List<Account> list = new List<Account>();
                list.Add(new Account()
                {
                    UserName = "Nick White",
                    RegistrationDate = DateTime.Today,
                    Married = true,
                    Age = 42
                });
                list.Add(new Account()
                {
                    UserName = "Jack Rodman",
                    RegistrationDate = new DateTime(2009, 5, 10),
                    Married = false,
                    Age = 30
                });
                list.Add(new Account()
                {
                    UserName = "Sandra Sherry",
                    RegistrationDate = new DateTime(2008, 12, 22),
                    Married = false,
                    Age = 18
                });
                list.Add(new Account()
                {
                    UserName = "Sabrina Vilk",
                    RegistrationDate = DateTime.Today,
                    Married = true,
                    Age = 24
                });
                list.Add(new Account()
                {
                    UserName = "Mike Pearson",
                    RegistrationDate = new DateTime(2008, 10, 18),
                    Married = true,
                    Age = 37
                });
                return list;
            }
        }
        public class Account {
            public string UserName { get; set; }
            public DateTime RegistrationDate { get; set; }
            public bool Married { get; set; }
            public int Age { get; set; }
        }
    }
}
