using eRestaurant.DAL;
using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL
{
    public class RestaurantAdminController
    {
        #region Manage Waiters

        #region Command

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddWaiter(Waiter item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                //TODO: Validation of waiter data...
                var added = context.Waiters.Add(item);
                context.SaveChanges();
                return added.WaiterID;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateWaiter(Waiter item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                //TODO: Validation of waiter data...
                var attached = context.Waiters.Attach(item);
                var matchingWithExistingValues = context.Entry<Waiter>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteWaiter(Waiter item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                //TODO: Validation of waiter data...
                var existing = context.Waiters.Find(item.WaiterID);
                context.Waiters.Remove(existing);
                context.SaveChanges();
            }
        }

        #endregion

        #region Query

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Waiter> ListAllWaiters()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Waiters.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Waiter GetWaiter(int waiterId)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Waiters.Find(waiterId);
            }
        }

        #endregion

        #endregion



        #region Manage Tables

        #region Command

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddTable(Table item)
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateTable(Table item)
        {

        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteTable(Table item)
        {

        }

        #endregion

        #region Query

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Table> ListAllTables()
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Table GetTable(int tableId)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion



        #region Manage Items

        #region Command

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddItem(Item item)
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateItem(Item item)
        {

        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteItem(Item item)
        {

        }

        #endregion

        #region Query

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Item> ListAllItems()
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Item GetItem(int itemId)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion



        #region Manage Special Events

        #region Command

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddSpecialEvent(SpecialEvent item)
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateSpecialEvent(SpecialEvent item)
        {

        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteSpecialEvent(SpecialEvent item)
        {

        }

        #endregion

        #region Query

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListAllSpecialEvents()
        {
            throw new NotImplementedException();
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SpecialEvent GetSpecialEvent(int specialEventId)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion


    }//end Class

}//end namespace