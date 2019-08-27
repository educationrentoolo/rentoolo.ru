﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class RentooloEntities : DbContext
    {
        public RentooloEntities()
            : base("name=RentooloEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Adverts> Adverts { get; set; }
        public DbSet<Applications> Applications { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Auctions> Auctions { get; set; }
        public DbSet<Business> Business { get; set; }
        public DbSet<CashIns> CashIns { get; set; }
        public DbSet<Currencies> Currencies { get; set; }
        public DbSet<DailyStatistics> DailyStatistics { get; set; }
        public DbSet<Exceptions> Exceptions { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<FavoritesByCookies> FavoritesByCookies { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<LoginStatistics> LoginStatistics { get; set; }
        public DbSet<Memberships> Memberships { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Operations> Operations { get; set; }
        public DbSet<Pavel_testTable> Pavel_testTable { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Referrals> Referrals { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersOpenAuthAccounts> UsersOpenAuthAccounts { get; set; }
        public DbSet<UsersOpenAuthData> UsersOpenAuthData { get; set; }
        public DbSet<Wallets> Wallets { get; set; }
        public DbSet<Categories> Categories { get; set; }
    
        [EdmFunction("RentooloEntities", "fnGetAllUsers")]
        public virtual IQueryable<fnGetAllUsers_Result> fnGetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetAllUsers_Result>("[RentooloEntities].[fnGetAllUsers]()");
        }
    
        [EdmFunction("RentooloEntities", "fnGetTablesRows")]
        public virtual IQueryable<fnGetTablesRows_Result> fnGetTablesRows()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetTablesRows_Result>("[RentooloEntities].[fnGetTablesRows]()");
        }
    
        [EdmFunction("RentooloEntities", "fnGetUserReferralsSecondLevel")]
        public virtual IQueryable<fnGetUserReferralsSecondLevel_Result> fnGetUserReferralsSecondLevel(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetUserReferralsSecondLevel_Result>("[RentooloEntities].[fnGetUserReferralsSecondLevel](@userId)", userIdParameter);
        }
    
        [EdmFunction("RentooloEntities", "fnGetUserReferralsThirdLevel")]
        public virtual IQueryable<fnGetUserReferralsThirdLevel_Result> fnGetUserReferralsThirdLevel(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetUserReferralsThirdLevel_Result>("[RentooloEntities].[fnGetUserReferralsThirdLevel](@userId)", userIdParameter);
        }
    
        [EdmFunction("RentooloEntities", "fnGetUserWallets")]
        public virtual IQueryable<fnGetUserWallets_Result> fnGetUserWallets(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnGetUserWallets_Result>("[RentooloEntities].[fnGetUserWallets](@userId)", userIdParameter);
        }
    
        public virtual int spAddFavorites(Nullable<System.Guid> userId, Nullable<long> advertId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(System.Guid));
    
            var advertIdParameter = advertId.HasValue ?
                new ObjectParameter("advertId", advertId) :
                new ObjectParameter("advertId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddFavorites", userIdParameter, advertIdParameter);
        }
    
        public virtual int spAddFavoritesByCookies(string uid, Nullable<long> advertId)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            var advertIdParameter = advertId.HasValue ?
                new ObjectParameter("advertId", advertId) :
                new ObjectParameter("advertId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddFavoritesByCookies", uidParameter, advertIdParameter);
        }
    
        public virtual ObjectResult<spGetFavorites_Result> spGetFavorites(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetFavorites_Result>("spGetFavorites", userIdParameter);
        }
    
        public virtual ObjectResult<spGetFavoritesByCookies_Result> spGetFavoritesByCookies(string uid)
        {
            var uidParameter = uid != null ?
                new ObjectParameter("uid", uid) :
                new ObjectParameter("uid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetFavoritesByCookies_Result>("spGetFavoritesByCookies", uidParameter);
        }
    
        public virtual int spGetLoginStatisticLastDayActive()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spGetLoginStatisticLastDayActive");
        }
    
        public virtual int spGetLoginStatisticLastHourActive()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spGetLoginStatisticLastHourActive");
        }
    
        public virtual ObjectResult<spGetUserAdverts_Result> spGetUserAdverts(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserAdverts_Result>("spGetUserAdverts", userIdParameter);
        }
    
        public virtual ObjectResult<spGetUserAuctions_Result> spGetUserAuctions(Nullable<System.Guid> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserAuctions_Result>("spGetUserAuctions", userIdParameter);
        }
    }
}
