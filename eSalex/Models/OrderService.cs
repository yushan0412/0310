﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSalex.Models
{
    /// <summary>
    /// 訂單的服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void InsertOrder(Models.Order order)
        {

        }

        /// <summary>
        /// 刪除訂單By Id
        /// </summary>
        public void DeleteOrder()
        {

        }

        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder()
        {

        }

        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(String id)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "叡揚資訊";
            return result;
        }

        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrders()
        {
          //List<Models.Order> result = new List<Order>();
         // result.Add(new Order() { CustId="GSS", CustName="叡揚資訊", EmpId=1, EmpName="王小明", Orderdate=DateTime.Parse("2017/04/06")
            return new List<Order>();
        }
        
    }
}