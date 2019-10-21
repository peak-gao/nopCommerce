﻿using Moq;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Data;
using Nop.Core.Domain.Discounts;
using Nop.Core.Domain.Orders;
using Nop.Data;
using Nop.Services.Catalog;
using Nop.Services.Customers;
using Nop.Services.Discounts;
using Nop.Services.Events;
using Nop.Services.Localization;
using Nop.Tests;

namespace Nop.Services.Tests.FakeServices
{
    public class FakeDiscountService : DiscountService
    {
        public FakeDiscountService(ICustomerService customerService = null,
            IDbContext dbContext = null,
            IDiscountPluginManager discountPluginManager = null,
            IEventPublisher eventPublisher = null,
            ILocalizationService localizationService = null,
            IProductService productService = null,
            IRepository<Discount> discountRepository = null,
            IRepository<DiscountRequirement> discountRequirementRepository = null,
            IRepository<DiscountUsageHistory> discountUsageHistoryRepository = null,
            IRepository<Order> orderRepository = null,
            IStaticCacheManager cacheManager = null,
            IStoreContext storeContext = null) : base(
                customerService ?? new Mock<ICustomerService>().Object,
                dbContext ?? new Mock<IDbContext>().Object,
                discountPluginManager ?? new Mock<IDiscountPluginManager>().Object,
                eventPublisher ?? new Mock<IEventPublisher>().Object,
                localizationService ?? new Mock<ILocalizationService>().Object,
                productService ?? new Mock<IProductService>().Object,
                discountRepository.FakeRepoNullPropagation(),
                discountRequirementRepository.FakeRepoNullPropagation(),
                discountUsageHistoryRepository.FakeRepoNullPropagation(),
                orderRepository.FakeRepoNullPropagation(),
                cacheManager ?? new TestCacheManager(),
                storeContext ?? new Mock<IStoreContext>().Object)
        {
        }
    }
}