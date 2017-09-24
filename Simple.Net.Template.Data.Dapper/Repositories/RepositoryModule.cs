using Autofac;
using Simple.Net.Template.Data.IRepositories;
using Simple.Net.Template.Data.Repositories;
using System;


namespace Simple.Net.Template.Data.Repositories
{
	public partial class RepositoryModule : Module
	{
		protected override void Load(ContainerBuilder builder)
        {
			    builder.RegisterType<DapperRepository>()
                .As<IRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatGreetContentConfigRepository>()
                .As<IWechatGreetContentConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceRecycleLogRepository>()
                .As<IResourceRecycleLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatGreetContentLogRepository>()
                .As<IWechatGreetContentLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceReportRepository>()
                .As<IResourceReportRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatGroupConfigRepository>()
                .As<IWechatGroupConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceResetPullLogRepository>()
                .As<IResourceResetPullLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatGroupContactMemberMongoRepository>()
                .As<IWechatGroupContactMemberMongoRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceSubPartRepository>()
                .As<IResourceSubPartRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatGroupContactMongoRepository>()
                .As<IWechatGroupContactMongoRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceSubTypeRepository>()
                .As<IResourceSubTypeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatGroupSendConfigRepository>()
                .As<IWechatGroupSendConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceTaskRepository>()
                .As<IResourceTaskRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatHandledResourceRepository>()
                .As<IWechatHandledResourceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceTaskLogRepository>()
                .As<IResourceTaskLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatHandledResourceLogRepository>()
                .As<IWechatHandledResourceLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceTrackRepository>()
                .As<IResourceTrackRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatMessageRepository>()
                .As<IWechatMessageRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceTypeRepository>()
                .As<IResourceTypeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatMessageMongoRepository>()
                .As<IWechatMessageMongoRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceTypeEmployeeDistributeConfigRepository>()
                .As<IResourceTypeEmployeeDistributeConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatPassiveAddResourceReportRepository>()
                .As<IWechatPassiveAddResourceReportRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceTypeGroupDistributeConfigRepository>()
                .As<IResourceTypeGroupDistributeConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WeChatRcontactRepository>()
                .As<IWeChatRcontactRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RoleEmployeeMappingRepository>()
                .As<IRoleEmployeeMappingRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BlackListRepository>()
                .As<IBlackListRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WeChatRcontactWebRepository>()
                .As<IWeChatRcontactWebRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RoleMenuMappingRepository>()
                .As<IRoleMenuMappingRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CallInfoRepository>()
                .As<ICallInfoRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatRecycleResouceRepository>()
                .As<IWechatRecycleResouceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RolesRepository>()
                .As<IRolesRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ChatMessageConfigRepository>()
                .As<IChatMessageConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatResourceRepository>()
                .As<IWechatResourceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ShareResourceRepository>()
                .As<IShareResourceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ChatMessageGroupConfigRepository>()
                .As<IChatMessageGroupConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatResourceApplyDetailLogRepository>()
                .As<IWechatResourceApplyDetailLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SystemConfigRepository>()
                .As<ISystemConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ChatRoomFavoriteRepository>()
                .As<IChatRoomFavoriteRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatResourceStepLogRepository>()
                .As<IWechatResourceStepLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TaskPullResourceLogRepository>()
                .As<ITaskPullResourceLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CityRepository>()
                .As<ICityRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatRestartPlanConfigRepository>()
                .As<IWechatRestartPlanConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TianYiAPPRepository>()
                .As<ITianYiAPPRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CompanyRepository>()
                .As<ICompanyRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatSearchAddFriendConfigRepository>()
                .As<IWechatSearchAddFriendConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserContactRepository>()
                .As<IUserContactRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CompanySystemConfigRepository>()
                .As<ICompanySystemConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatSearchAddFriendLogRepository>()
                .As<IWechatSearchAddFriendLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserFundFlowRepository>()
                .As<IUserFundFlowRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ContactActionRepository>()
                .As<IContactActionRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatTaskRepository>()
                .As<IWechatTaskRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserFundsRepository>()
                .As<IUserFundsRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ContactTypeRepository>()
                .As<IContactTypeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatTaskExtendRepository>()
                .As<IWechatTaskExtendRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserInAccountRepository>()
                .As<IUserInAccountRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ContactTypeActionMappingRepository>()
                .As<IContactTypeActionMappingRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatTaskLogRepository>()
                .As<IWechatTaskLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserInAccountApplyRepository>()
                .As<IUserInAccountApplyRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DepartmentRepository>()
                .As<IDepartmentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WorkDiariesRepository>()
                .As<IWorkDiariesRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserInfoRepository>()
                .As<IUserInfoRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<Department_CompanyRepository>()
                .As<IDepartment_CompanyRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderRepository>()
                .As<IUserOrderRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DiaryTypeRepository>()
                .As<IDiaryTypeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderAuthorizationApplyRepository>()
                .As<IUserOrderAuthorizationApplyRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DictionaryRepository>()
                .As<IDictionaryRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderInAccountApplyRepository>()
                .As<IUserOrderInAccountApplyRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeRepository>()
                .As<IEmployeeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderInAccountRecordRepository>()
                .As<IUserOrderInAccountRecordRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeConcactRepository>()
                .As<IEmployeeConcactRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderLogRepository>()
                .As<IUserOrderLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeConcactLogRepository>()
                .As<IEmployeeConcactLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderPaymentRepository>()
                .As<IUserOrderPaymentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeDistributeConfigRepository>()
                .As<IEmployeeDistributeConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderProductAuthorizationRepository>()
                .As<IUserOrderProductAuthorizationRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeDistributeConfigLogRepository>()
                .As<IEmployeeDistributeConfigLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderRefundRepository>()
                .As<IUserOrderRefundRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeLevelRepository>()
                .As<IEmployeeLevelRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderRefundLogRepository>()
                .As<IUserOrderRefundLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeOpenFunctionRepository>()
                .As<IEmployeeOpenFunctionRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderRefundMaterialRepository>()
                .As<IUserOrderRefundMaterialRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeOrganizationRepository>()
                .As<IEmployeeOrganizationRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderRefundPaymentRepository>()
                .As<IUserOrderRefundPaymentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeOrganizationDetailRepository>()
                .As<IEmployeeOrganizationDetailRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderServiceEmployeeRepository>()
                .As<IUserOrderServiceEmployeeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeQueueRepository>()
                .As<IEmployeeQueueRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserOrderUpdateRelationRepository>()
                .As<IUserOrderUpdateRelationRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeResourceConfigRepository>()
                .As<IEmployeeResourceConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserPortraitConfigRepository>()
                .As<IUserPortraitConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeUserLogRepository>()
                .As<IEmployeeUserLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserPortraitInfoRepository>()
                .As<IUserPortraitInfoRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeWeChatCodeRepository>()
                .As<IEmployeeWeChatCodeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TradeAccountRepository>()
                .As<ITradeAccountRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserProductAuthorizationRepository>()
                .As<IUserProductAuthorizationRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<FastReplyConfigRepository>()
                .As<IFastReplyConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserExtRepository>()
                .As<IUserExtRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserProductAuthorizationStopRecordRepository>()
                .As<IUserProductAuthorizationStopRecordRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<FastReplyGroupConfigRepository>()
                .As<IFastReplyGroupConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserMergeApplyRepository>()
                .As<IUserMergeApplyRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserRemarkRepository>()
                .As<IUserRemarkRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<Group_DepartmentRepository>()
                .As<IGroup_DepartmentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserRiskRepository>()
                .As<IUserRiskRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<GroupResourceConfigRepository>()
                .As<IGroupResourceConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RobotRepository>()
                .As<IRobotRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UsersRepository>()
                .As<IUsersRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<GroupsRepository>()
                .As<IGroupsRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<LabelRepository>()
                .As<ILabelRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserTypeRepository>()
                .As<IUserTypeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<LevelConfigRepository>()
                .As<ILevelConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<LabelCategoryRepository>()
                .As<ILabelCategoryRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<VersionRepository>()
                .As<IVersionRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<MenuRepository>()
                .As<IMenuRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceLogJobRepository>()
                .As<IResourceLogJobRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ViolationKeyWordConfigRepository>()
                .As<IViolationKeyWordConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<MyResourcesRepository>()
                .As<IMyResourcesRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserLableRepository>()
                .As<IUserLableRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ViolationRecordRepository>()
                .As<IViolationRecordRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<NewCallInfoRepository>()
                .As<INewCallInfoRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ViolationTypeConfigRepository>()
                .As<IViolationTypeConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<NewResourcesRepository>()
                .As<INewResourcesRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WaitAssignResourceRepository>()
                .As<IWaitAssignResourceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<NumberSectionRepository>()
                .As<INumberSectionRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WaitRemarkRepository>()
                .As<IWaitRemarkRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<OrderSplitRecordRepository>()
                .As<IOrderSplitRecordRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatAddFriendConfigRepository>()
                .As<IWechatAddFriendConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductRepository>()
                .As<IProductRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatAddFriendConfigLogRepository>()
                .As<IWechatAddFriendConfigLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductCategoryRepository>()
                .As<IProductCategoryRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatAddFriendTestersRepository>()
                .As<IWechatAddFriendTestersRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProvinceRepository>()
                .As<IProvinceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatAddResourceReportRepository>()
                .As<IWechatAddResourceReportRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PublicResourcesRepository>()
                .As<IPublicResourcesRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WeChatAuthorizationRepository>()
                .As<IWeChatAuthorizationRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RandomTimeListRepository>()
                .As<IRandomTimeListRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WeChatAuthorizationUpdateLogRepository>()
                .As<IWeChatAuthorizationUpdateLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RequestAndReturnTaskLogRepository>()
                .As<IRequestAndReturnTaskLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatAutoAddResourceReportRepository>()
                .As<IWechatAutoAddResourceReportRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceRepository>()
                .As<IResourceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatContactBakRepository>()
                .As<IWechatContactBakRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceAddWechatLogRepository>()
                .As<IResourceAddWechatLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatContactBakWebRepository>()
                .As<IWechatContactBakWebRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceAssignLogRepository>()
                .As<IResourceAssignLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatContactMongoRepository>()
                .As<IWechatContactMongoRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceDayReportRepository>()
                .As<IResourceDayReportRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WeChatContactWebLogRepository>()
                .As<IWeChatContactWebLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceDistributeRepository>()
                .As<IResourceDistributeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatExceptionRecordRepository>()
                .As<IWechatExceptionRecordRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceExtendRepository>()
                .As<IResourceExtendRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatExceptionRecordLogRepository>()
                .As<IWechatExceptionRecordLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceLogRepository>()
                .As<IResourceLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatFilterResourceRepository>()
                .As<IWechatFilterResourceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourceMonthReportRepository>()
                .As<IResourceMonthReportRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatFriendCircleConfigRepository>()
                .As<IWechatFriendCircleConfigRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourcePoolRepository>()
                .As<IResourcePoolRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WechatFriendCircleConfigLogRepository>()
                .As<IWechatFriendCircleConfigLogRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResourcePullAndAddWechatLogRepository>()
                .As<IResourcePullAndAddWechatLogRepository>()
                .InstancePerLifetimeScope();

        }
	}
}
