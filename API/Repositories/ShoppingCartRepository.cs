﻿using API.Data;
using API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using WebBHModels.Dtos;
using WebsiteBanHang.Entities;

namespace API.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly BHDbContext _db;
        public ShoppingCartRepository(BHDbContext db)
        {
            _db = db;
        }
        // xét nếu có item thì trả về true, nếu ko thì về false
        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await _db.CartItems
                .AnyAsync(c => c.CartId == cartId && c.ProductId == productId);
            
        }

        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if( await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
            {

            }
            var item = await (from product in _db.Products
                              where product.Id == cartItemToAddDto.ProductId
                              select new CartItem
                              {
                                  CartId = cartItemToAddDto.CartId,
                                  ProductId = product.Id,
                                  Qty = cartItemToAddDto.Qty,
                              }).SingleOrDefaultAsync();

            if(item != null)
            {
                var ketQua = await _db.CartItems.AddAsync(item);
                await _db.SaveChangesAsync();
                return ketQua.Entity;
            }

            return null;
        }

        public Task<CartItem> DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        //public async Task<CartItem> GetItem(int id)
        //{
        //    return await(from cart in _db.Carts
        //                 join cartItem in _db.CartItems
        //                 on cart.Id equals cartItem.CartId
        //                 where cartItem.Id == id
        //                 select new CartItem
        //                 {
        //                     Id = cartItem.Id,
        //                     ProductId = cartItem.ProductId,
        //                     Qty = cartItem.Qty,
        //                     CartId = cartItem.CartId,
        //                 }).SingleOrDefaultAsync();
        //}

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in _db.Carts
                          join cartItem in _db.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId,
                          }
                          ).ToListAsync();
        }

        public Task<CartItem> UpdateItem(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
