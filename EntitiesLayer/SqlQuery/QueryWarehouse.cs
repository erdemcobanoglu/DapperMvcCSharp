using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace EntitiesLayer.SqlQuery
{
    public static class QueryWarehouse
    {
        public static class Account
        {
            public static string Insert => "";
            public static string Update => "";
            public static string Delete => "";
            public static string GetAll => "select * from Account with(nolock)";
            public static string GetById => "";
        }
        public static class City
        {
            public static string Insert => "";
            public static string Update => "";
            public static string Delete => "";
            public static string GetAll => "select * from City with(nolock)";
            public static string GetById => "";
        }
        public static class Country
        {
            public static string Insert => "";
            public static string Update => "";
            public static string Delete => "";
            public static string GetAll => "select * from Country with(nolock)";
            public static string GetById => "";
        } 
        public static class Customer
        {
            public static string Insert => "";
            public static string Update => "";
            public static string Delete => "";
            public static string GetAll => "select * from Customer with(nolock)";
            public static string GetById => "";
        }
    }
}
