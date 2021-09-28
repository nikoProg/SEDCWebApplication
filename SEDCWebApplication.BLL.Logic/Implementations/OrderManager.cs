using AutoMapper;
using SEDCWebApplication.BLL.Logic.Interfaces;
using SEDCWebApplication.BLL.Logic.Models;
using SEDCWebApplication.DAL.DatabaseFactory.Entities;
using SEDCWebApplication.DAL.DatabaseFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDCWebApplication.BLL.Logic.Implementations
{
    public class OrderManager : IOrderManager
    {

        private readonly IOrderDAL _orderDAL;
        private readonly IProductDAL _productDAL;
        private readonly IMapper _mapper;
        public OrderManager(IOrderDAL orderDAL, IProductDAL productDAL, IMapper mapper)
        {
            _orderDAL = orderDAL;
            _productDAL = productDAL;
            _mapper = mapper;
        }
        public OrderDTO Add(OrderDTO orderDto)
        {
            //inicijalizovati order, order.TotalAmount = 0
            Order order = new Order();
            order.TotalAmount = 0;
            order.Number = CreateOrderNumber();
            order.Status = 1;
            order.OrderItems = new List<OrderItem>();

            //za svaki OrderItem iz orderDto.OrderItems pronaci Product 
            //po ProductId-u i cenu dobijenog product-a pomnoziti sa Quantity 
            //i dodati u order.TotalAmount

            foreach (OrderItemDTO orderItemDto in orderDto.OrderItems)
            {
                Product product = _productDAL.GetById(orderItemDto.ProductId);
                order.TotalAmount += product.UnitPrice * orderItemDto.Quantity;

                OrderItem orderItem = new OrderItem();
                orderItem.ProductId = product.Id;
                orderItem.Quantity = orderItemDto.Quantity;

                order.OrderItems.Add(orderItem);

            }

            //poslati order na snimanje u orderDAL i vratiti snimljeni order, mapirati u orderDTO
            _orderDAL.Save(order);


            return orderDto;
        }

        private string CreateOrderNumber()
        {
            return "N";
        }
    }
}
