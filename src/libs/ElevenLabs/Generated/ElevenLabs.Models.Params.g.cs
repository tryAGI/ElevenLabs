#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Params : global::System.IEquatable<Params>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType? SmbToolType { get; }

        /// <summary>
        /// Search for clients by name, phone number, or email.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SearchClientsParams? SearchClients { get; init; }
#else
        public global::ElevenLabs.SearchClientsParams? SearchClients { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchClients))]
#endif
        public bool IsSearchClients => SearchClients != null;

        /// <summary>
        /// List clients ordered by most recently updated, with an optional limit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListClientsParams? ListClients { get; init; }
#else
        public global::ElevenLabs.ListClientsParams? ListClients { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListClients))]
#endif
        public bool IsListClients => ListClients != null;

        /// <summary>
        /// Look up a client by their exact phone number.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetClientByPhoneParams? GetClientByPhone { get; init; }
#else
        public global::ElevenLabs.GetClientByPhoneParams? GetClientByPhone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetClientByPhone))]
#endif
        public bool IsGetClientByPhone => GetClientByPhone != null;

        /// <summary>
        /// Create a new client in the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateClientParams? CreateClient { get; init; }
#else
        public global::ElevenLabs.CreateClientParams? CreateClient { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateClient))]
#endif
        public bool IsCreateClient => CreateClient != null;

        /// <summary>
        /// Update an existing client's information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateClientParams? UpdateClient { get; init; }
#else
        public global::ElevenLabs.UpdateClientParams? UpdateClient { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateClient))]
#endif
        public bool IsUpdateClient => UpdateClient != null;

        /// <summary>
        /// Delete an existing client from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteClientParams? DeleteClient { get; init; }
#else
        public global::ElevenLabs.DeleteClientParams? DeleteClient { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteClient))]
#endif
        public bool IsDeleteClient => DeleteClient != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListStaffParams? ListStaff { get; init; }
#else
        public global::ElevenLabs.ListStaffParams? ListStaff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListStaff))]
#endif
        public bool IsListStaff => ListStaff != null;

        /// <summary>
        /// Create a new staff member in the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateStaffParams? CreateStaff { get; init; }
#else
        public global::ElevenLabs.CreateStaffParams? CreateStaff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateStaff))]
#endif
        public bool IsCreateStaff => CreateStaff != null;

        /// <summary>
        /// Update an existing staff member's information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateStaffParams? UpdateStaff { get; init; }
#else
        public global::ElevenLabs.UpdateStaffParams? UpdateStaff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateStaff))]
#endif
        public bool IsUpdateStaff => UpdateStaff != null;

        /// <summary>
        /// Delete an existing staff member from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteStaffParams? DeleteStaff { get; init; }
#else
        public global::ElevenLabs.DeleteStaffParams? DeleteStaff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteStaff))]
#endif
        public bool IsDeleteStaff => DeleteStaff != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListAssetsParams? ListAssets { get; init; }
#else
        public global::ElevenLabs.ListAssetsParams? ListAssets { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListAssets))]
#endif
        public bool IsListAssets => ListAssets != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateAssetParams? CreateAsset { get; init; }
#else
        public global::ElevenLabs.CreateAssetParams? CreateAsset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateAsset))]
#endif
        public bool IsCreateAsset => CreateAsset != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateAssetParams? UpdateAsset { get; init; }
#else
        public global::ElevenLabs.UpdateAssetParams? UpdateAsset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateAsset))]
#endif
        public bool IsUpdateAsset => UpdateAsset != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteAssetParams? DeleteAsset { get; init; }
#else
        public global::ElevenLabs.DeleteAssetParams? DeleteAsset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteAsset))]
#endif
        public bool IsDeleteAsset => DeleteAsset != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListServicesParams? ListServices { get; init; }
#else
        public global::ElevenLabs.ListServicesParams? ListServices { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListServices))]
#endif
        public bool IsListServices => ListServices != null;

        /// <summary>
        /// Create a new service in the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateServiceParams? CreateService { get; init; }
#else
        public global::ElevenLabs.CreateServiceParams? CreateService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateService))]
#endif
        public bool IsCreateService => CreateService != null;

        /// <summary>
        /// Update an existing service's information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateServiceParams? UpdateService { get; init; }
#else
        public global::ElevenLabs.UpdateServiceParams? UpdateService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateService))]
#endif
        public bool IsUpdateService => UpdateService != null;

        /// <summary>
        /// Delete an existing service from the system.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteServiceParams? DeleteService { get; init; }
#else
        public global::ElevenLabs.DeleteServiceParams? DeleteService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteService))]
#endif
        public bool IsDeleteService => DeleteService != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListProductsParams? ListProducts { get; init; }
#else
        public global::ElevenLabs.ListProductsParams? ListProducts { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListProducts))]
#endif
        public bool IsListProducts => ListProducts != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateProductParams? CreateProduct { get; init; }
#else
        public global::ElevenLabs.CreateProductParams? CreateProduct { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateProduct))]
#endif
        public bool IsCreateProduct => CreateProduct != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateProductParams? UpdateProduct { get; init; }
#else
        public global::ElevenLabs.UpdateProductParams? UpdateProduct { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateProduct))]
#endif
        public bool IsUpdateProduct => UpdateProduct != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteProductParams? DeleteProduct { get; init; }
#else
        public global::ElevenLabs.DeleteProductParams? DeleteProduct { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteProduct))]
#endif
        public bool IsDeleteProduct => DeleteProduct != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CheckServiceAvailabilityParams? CheckServiceAvailability { get; init; }
#else
        public global::ElevenLabs.CheckServiceAvailabilityParams? CheckServiceAvailability { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CheckServiceAvailability))]
#endif
        public bool IsCheckServiceAvailability => CheckServiceAvailability != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateClientAppointmentParams? CreateClientAppointment { get; init; }
#else
        public global::ElevenLabs.CreateClientAppointmentParams? CreateClientAppointment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateClientAppointment))]
#endif
        public bool IsCreateClientAppointment => CreateClientAppointment != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetClientAppointmentsParams? GetClientAppointments { get; init; }
#else
        public global::ElevenLabs.GetClientAppointmentsParams? GetClientAppointments { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetClientAppointments))]
#endif
        public bool IsGetClientAppointments => GetClientAppointments != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListCalendarEventsParams? ListCalendarEvents { get; init; }
#else
        public global::ElevenLabs.ListCalendarEventsParams? ListCalendarEvents { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListCalendarEvents))]
#endif
        public bool IsListCalendarEvents => ListCalendarEvents != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateCalendarEventParams? UpdateCalendarEvent { get; init; }
#else
        public global::ElevenLabs.UpdateCalendarEventParams? UpdateCalendarEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateCalendarEvent))]
#endif
        public bool IsUpdateCalendarEvent => UpdateCalendarEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteCalendarEventParams? DeleteCalendarEvent { get; init; }
#else
        public global::ElevenLabs.DeleteCalendarEventParams? DeleteCalendarEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteCalendarEvent))]
#endif
        public bool IsDeleteCalendarEvent => DeleteCalendarEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListRentalServicesParams? ListRentalServices { get; init; }
#else
        public global::ElevenLabs.ListRentalServicesParams? ListRentalServices { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListRentalServices))]
#endif
        public bool IsListRentalServices => ListRentalServices != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateRentalServiceParams? CreateRentalService { get; init; }
#else
        public global::ElevenLabs.CreateRentalServiceParams? CreateRentalService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateRentalService))]
#endif
        public bool IsCreateRentalService => CreateRentalService != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateRentalServiceParams? UpdateRentalService { get; init; }
#else
        public global::ElevenLabs.UpdateRentalServiceParams? UpdateRentalService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateRentalService))]
#endif
        public bool IsUpdateRentalService => UpdateRentalService != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteRentalServiceParams? DeleteRentalService { get; init; }
#else
        public global::ElevenLabs.DeleteRentalServiceParams? DeleteRentalService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteRentalService))]
#endif
        public bool IsDeleteRentalService => DeleteRentalService != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CheckRentalAvailabilityParams? CheckRentalAvailability { get; init; }
#else
        public global::ElevenLabs.CheckRentalAvailabilityParams? CheckRentalAvailability { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CheckRentalAvailability))]
#endif
        public bool IsCheckRentalAvailability => CheckRentalAvailability != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateRentalBookingParams? CreateRentalBooking { get; init; }
#else
        public global::ElevenLabs.CreateRentalBookingParams? CreateRentalBooking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateRentalBooking))]
#endif
        public bool IsCreateRentalBooking => CreateRentalBooking != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListAgentRulesParams? ListAgentRules { get; init; }
#else
        public global::ElevenLabs.ListAgentRulesParams? ListAgentRules { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListAgentRules))]
#endif
        public bool IsListAgentRules => ListAgentRules != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateAgentRuleParams? CreateAgentRule { get; init; }
#else
        public global::ElevenLabs.CreateAgentRuleParams? CreateAgentRule { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateAgentRule))]
#endif
        public bool IsCreateAgentRule => CreateAgentRule != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateAgentRuleParams? UpdateAgentRule { get; init; }
#else
        public global::ElevenLabs.UpdateAgentRuleParams? UpdateAgentRule { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateAgentRule))]
#endif
        public bool IsUpdateAgentRule => UpdateAgentRule != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteAgentRuleParams? DeleteAgentRule { get; init; }
#else
        public global::ElevenLabs.DeleteAgentRuleParams? DeleteAgentRule { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteAgentRule))]
#endif
        public bool IsDeleteAgentRule => DeleteAgentRule != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListHolidaysParams? ListHolidays { get; init; }
#else
        public global::ElevenLabs.ListHolidaysParams? ListHolidays { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListHolidays))]
#endif
        public bool IsListHolidays => ListHolidays != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateHolidayParams? CreateHoliday { get; init; }
#else
        public global::ElevenLabs.CreateHolidayParams? CreateHoliday { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateHoliday))]
#endif
        public bool IsCreateHoliday => CreateHoliday != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateHolidayParams? UpdateHoliday { get; init; }
#else
        public global::ElevenLabs.UpdateHolidayParams? UpdateHoliday { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateHoliday))]
#endif
        public bool IsUpdateHoliday => UpdateHoliday != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteHolidayParams? DeleteHoliday { get; init; }
#else
        public global::ElevenLabs.DeleteHolidayParams? DeleteHoliday { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteHoliday))]
#endif
        public bool IsDeleteHoliday => DeleteHoliday != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetScheduleParams? GetSchedule { get; init; }
#else
        public global::ElevenLabs.GetScheduleParams? GetSchedule { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetSchedule))]
#endif
        public bool IsGetSchedule => GetSchedule != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateBusinessInfoParams? UpdateBusinessInfo { get; init; }
#else
        public global::ElevenLabs.UpdateBusinessInfoParams? UpdateBusinessInfo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateBusinessInfo))]
#endif
        public bool IsUpdateBusinessInfo => UpdateBusinessInfo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateCustomerFacingConfigParams? UpdateCustomerFacingConfig { get; init; }
#else
        public global::ElevenLabs.UpdateCustomerFacingConfigParams? UpdateCustomerFacingConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateCustomerFacingConfig))]
#endif
        public bool IsUpdateCustomerFacingConfig => UpdateCustomerFacingConfig != null;

        /// <summary>
        /// Get a summary of key business analytics for a time period.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetAnalyticsSummaryParams? GetAnalyticsSummary { get; init; }
#else
        public global::ElevenLabs.GetAnalyticsSummaryParams? GetAnalyticsSummary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetAnalyticsSummary))]
#endif
        public bool IsGetAnalyticsSummary => GetAnalyticsSummary != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetBookingPageSettingsParams? GetBookingPageSettings { get; init; }
#else
        public global::ElevenLabs.GetBookingPageSettingsParams? GetBookingPageSettings { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetBookingPageSettings))]
#endif
        public bool IsGetBookingPageSettings => GetBookingPageSettings != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateBookingPageSettingsParams? UpdateBookingPageSettings { get; init; }
#else
        public global::ElevenLabs.UpdateBookingPageSettingsParams? UpdateBookingPageSettings { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateBookingPageSettings))]
#endif
        public bool IsUpdateBookingPageSettings => UpdateBookingPageSettings != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetBookingSlugStatusParams? GetBookingSlugStatus { get; init; }
#else
        public global::ElevenLabs.GetBookingSlugStatusParams? GetBookingSlugStatus { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetBookingSlugStatus))]
#endif
        public bool IsGetBookingSlugStatus => GetBookingSlugStatus != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SetBookingSlugParams? SetBookingSlug { get; init; }
#else
        public global::ElevenLabs.SetBookingSlugParams? SetBookingSlug { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SetBookingSlug))]
#endif
        public bool IsSetBookingSlug => SetBookingSlug != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListClientInteractionsParams? ListClientInteractions { get; init; }
#else
        public global::ElevenLabs.ListClientInteractionsParams? ListClientInteractions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListClientInteractions))]
#endif
        public bool IsListClientInteractions => ListClientInteractions != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateClientInteractionParams? CreateClientInteraction { get; init; }
#else
        public global::ElevenLabs.CreateClientInteractionParams? CreateClientInteraction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateClientInteraction))]
#endif
        public bool IsCreateClientInteraction => CreateClientInteraction != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteClientInteractionParams? DeleteClientInteraction { get; init; }
#else
        public global::ElevenLabs.DeleteClientInteractionParams? DeleteClientInteraction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteClientInteraction))]
#endif
        public bool IsDeleteClientInteraction => DeleteClientInteraction != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.SearchClientsParams value) => new Params((global::ElevenLabs.SearchClientsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SearchClientsParams?(Params @this) => @this.SearchClients;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.SearchClientsParams? value)
        {
            SearchClients = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListClientsParams value) => new Params((global::ElevenLabs.ListClientsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListClientsParams?(Params @this) => @this.ListClients;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListClientsParams? value)
        {
            ListClients = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.GetClientByPhoneParams value) => new Params((global::ElevenLabs.GetClientByPhoneParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetClientByPhoneParams?(Params @this) => @this.GetClientByPhone;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.GetClientByPhoneParams? value)
        {
            GetClientByPhone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateClientParams value) => new Params((global::ElevenLabs.CreateClientParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateClientParams?(Params @this) => @this.CreateClient;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateClientParams? value)
        {
            CreateClient = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateClientParams value) => new Params((global::ElevenLabs.UpdateClientParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateClientParams?(Params @this) => @this.UpdateClient;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateClientParams? value)
        {
            UpdateClient = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteClientParams value) => new Params((global::ElevenLabs.DeleteClientParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteClientParams?(Params @this) => @this.DeleteClient;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteClientParams? value)
        {
            DeleteClient = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListStaffParams value) => new Params((global::ElevenLabs.ListStaffParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListStaffParams?(Params @this) => @this.ListStaff;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListStaffParams? value)
        {
            ListStaff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateStaffParams value) => new Params((global::ElevenLabs.CreateStaffParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateStaffParams?(Params @this) => @this.CreateStaff;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateStaffParams? value)
        {
            CreateStaff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateStaffParams value) => new Params((global::ElevenLabs.UpdateStaffParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateStaffParams?(Params @this) => @this.UpdateStaff;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateStaffParams? value)
        {
            UpdateStaff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteStaffParams value) => new Params((global::ElevenLabs.DeleteStaffParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteStaffParams?(Params @this) => @this.DeleteStaff;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteStaffParams? value)
        {
            DeleteStaff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListAssetsParams value) => new Params((global::ElevenLabs.ListAssetsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListAssetsParams?(Params @this) => @this.ListAssets;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListAssetsParams? value)
        {
            ListAssets = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateAssetParams value) => new Params((global::ElevenLabs.CreateAssetParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateAssetParams?(Params @this) => @this.CreateAsset;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateAssetParams? value)
        {
            CreateAsset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateAssetParams value) => new Params((global::ElevenLabs.UpdateAssetParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateAssetParams?(Params @this) => @this.UpdateAsset;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateAssetParams? value)
        {
            UpdateAsset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteAssetParams value) => new Params((global::ElevenLabs.DeleteAssetParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteAssetParams?(Params @this) => @this.DeleteAsset;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteAssetParams? value)
        {
            DeleteAsset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListServicesParams value) => new Params((global::ElevenLabs.ListServicesParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListServicesParams?(Params @this) => @this.ListServices;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListServicesParams? value)
        {
            ListServices = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateServiceParams value) => new Params((global::ElevenLabs.CreateServiceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateServiceParams?(Params @this) => @this.CreateService;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateServiceParams? value)
        {
            CreateService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateServiceParams value) => new Params((global::ElevenLabs.UpdateServiceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateServiceParams?(Params @this) => @this.UpdateService;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateServiceParams? value)
        {
            UpdateService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteServiceParams value) => new Params((global::ElevenLabs.DeleteServiceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteServiceParams?(Params @this) => @this.DeleteService;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteServiceParams? value)
        {
            DeleteService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListProductsParams value) => new Params((global::ElevenLabs.ListProductsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListProductsParams?(Params @this) => @this.ListProducts;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListProductsParams? value)
        {
            ListProducts = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateProductParams value) => new Params((global::ElevenLabs.CreateProductParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateProductParams?(Params @this) => @this.CreateProduct;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateProductParams? value)
        {
            CreateProduct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateProductParams value) => new Params((global::ElevenLabs.UpdateProductParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateProductParams?(Params @this) => @this.UpdateProduct;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateProductParams? value)
        {
            UpdateProduct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteProductParams value) => new Params((global::ElevenLabs.DeleteProductParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteProductParams?(Params @this) => @this.DeleteProduct;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteProductParams? value)
        {
            DeleteProduct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CheckServiceAvailabilityParams value) => new Params((global::ElevenLabs.CheckServiceAvailabilityParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CheckServiceAvailabilityParams?(Params @this) => @this.CheckServiceAvailability;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CheckServiceAvailabilityParams? value)
        {
            CheckServiceAvailability = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateClientAppointmentParams value) => new Params((global::ElevenLabs.CreateClientAppointmentParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateClientAppointmentParams?(Params @this) => @this.CreateClientAppointment;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateClientAppointmentParams? value)
        {
            CreateClientAppointment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.GetClientAppointmentsParams value) => new Params((global::ElevenLabs.GetClientAppointmentsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetClientAppointmentsParams?(Params @this) => @this.GetClientAppointments;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.GetClientAppointmentsParams? value)
        {
            GetClientAppointments = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListCalendarEventsParams value) => new Params((global::ElevenLabs.ListCalendarEventsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListCalendarEventsParams?(Params @this) => @this.ListCalendarEvents;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListCalendarEventsParams? value)
        {
            ListCalendarEvents = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateCalendarEventParams value) => new Params((global::ElevenLabs.UpdateCalendarEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateCalendarEventParams?(Params @this) => @this.UpdateCalendarEvent;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateCalendarEventParams? value)
        {
            UpdateCalendarEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteCalendarEventParams value) => new Params((global::ElevenLabs.DeleteCalendarEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteCalendarEventParams?(Params @this) => @this.DeleteCalendarEvent;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteCalendarEventParams? value)
        {
            DeleteCalendarEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListRentalServicesParams value) => new Params((global::ElevenLabs.ListRentalServicesParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListRentalServicesParams?(Params @this) => @this.ListRentalServices;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListRentalServicesParams? value)
        {
            ListRentalServices = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateRentalServiceParams value) => new Params((global::ElevenLabs.CreateRentalServiceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateRentalServiceParams?(Params @this) => @this.CreateRentalService;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateRentalServiceParams? value)
        {
            CreateRentalService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateRentalServiceParams value) => new Params((global::ElevenLabs.UpdateRentalServiceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateRentalServiceParams?(Params @this) => @this.UpdateRentalService;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateRentalServiceParams? value)
        {
            UpdateRentalService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteRentalServiceParams value) => new Params((global::ElevenLabs.DeleteRentalServiceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteRentalServiceParams?(Params @this) => @this.DeleteRentalService;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteRentalServiceParams? value)
        {
            DeleteRentalService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CheckRentalAvailabilityParams value) => new Params((global::ElevenLabs.CheckRentalAvailabilityParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CheckRentalAvailabilityParams?(Params @this) => @this.CheckRentalAvailability;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CheckRentalAvailabilityParams? value)
        {
            CheckRentalAvailability = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateRentalBookingParams value) => new Params((global::ElevenLabs.CreateRentalBookingParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateRentalBookingParams?(Params @this) => @this.CreateRentalBooking;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateRentalBookingParams? value)
        {
            CreateRentalBooking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListAgentRulesParams value) => new Params((global::ElevenLabs.ListAgentRulesParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListAgentRulesParams?(Params @this) => @this.ListAgentRules;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListAgentRulesParams? value)
        {
            ListAgentRules = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateAgentRuleParams value) => new Params((global::ElevenLabs.CreateAgentRuleParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateAgentRuleParams?(Params @this) => @this.CreateAgentRule;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateAgentRuleParams? value)
        {
            CreateAgentRule = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateAgentRuleParams value) => new Params((global::ElevenLabs.UpdateAgentRuleParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateAgentRuleParams?(Params @this) => @this.UpdateAgentRule;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateAgentRuleParams? value)
        {
            UpdateAgentRule = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteAgentRuleParams value) => new Params((global::ElevenLabs.DeleteAgentRuleParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteAgentRuleParams?(Params @this) => @this.DeleteAgentRule;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteAgentRuleParams? value)
        {
            DeleteAgentRule = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListHolidaysParams value) => new Params((global::ElevenLabs.ListHolidaysParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListHolidaysParams?(Params @this) => @this.ListHolidays;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListHolidaysParams? value)
        {
            ListHolidays = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateHolidayParams value) => new Params((global::ElevenLabs.CreateHolidayParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateHolidayParams?(Params @this) => @this.CreateHoliday;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateHolidayParams? value)
        {
            CreateHoliday = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateHolidayParams value) => new Params((global::ElevenLabs.UpdateHolidayParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateHolidayParams?(Params @this) => @this.UpdateHoliday;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateHolidayParams? value)
        {
            UpdateHoliday = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteHolidayParams value) => new Params((global::ElevenLabs.DeleteHolidayParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteHolidayParams?(Params @this) => @this.DeleteHoliday;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteHolidayParams? value)
        {
            DeleteHoliday = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.GetScheduleParams value) => new Params((global::ElevenLabs.GetScheduleParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetScheduleParams?(Params @this) => @this.GetSchedule;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.GetScheduleParams? value)
        {
            GetSchedule = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateBusinessInfoParams value) => new Params((global::ElevenLabs.UpdateBusinessInfoParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateBusinessInfoParams?(Params @this) => @this.UpdateBusinessInfo;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateBusinessInfoParams? value)
        {
            UpdateBusinessInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateCustomerFacingConfigParams value) => new Params((global::ElevenLabs.UpdateCustomerFacingConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateCustomerFacingConfigParams?(Params @this) => @this.UpdateCustomerFacingConfig;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateCustomerFacingConfigParams? value)
        {
            UpdateCustomerFacingConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.GetAnalyticsSummaryParams value) => new Params((global::ElevenLabs.GetAnalyticsSummaryParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetAnalyticsSummaryParams?(Params @this) => @this.GetAnalyticsSummary;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.GetAnalyticsSummaryParams? value)
        {
            GetAnalyticsSummary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.GetBookingPageSettingsParams value) => new Params((global::ElevenLabs.GetBookingPageSettingsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetBookingPageSettingsParams?(Params @this) => @this.GetBookingPageSettings;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.GetBookingPageSettingsParams? value)
        {
            GetBookingPageSettings = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateBookingPageSettingsParams value) => new Params((global::ElevenLabs.UpdateBookingPageSettingsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateBookingPageSettingsParams?(Params @this) => @this.UpdateBookingPageSettings;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateBookingPageSettingsParams? value)
        {
            UpdateBookingPageSettings = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.GetBookingSlugStatusParams value) => new Params((global::ElevenLabs.GetBookingSlugStatusParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetBookingSlugStatusParams?(Params @this) => @this.GetBookingSlugStatus;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.GetBookingSlugStatusParams? value)
        {
            GetBookingSlugStatus = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.SetBookingSlugParams value) => new Params((global::ElevenLabs.SetBookingSlugParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SetBookingSlugParams?(Params @this) => @this.SetBookingSlug;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.SetBookingSlugParams? value)
        {
            SetBookingSlug = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListClientInteractionsParams value) => new Params((global::ElevenLabs.ListClientInteractionsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListClientInteractionsParams?(Params @this) => @this.ListClientInteractions;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListClientInteractionsParams? value)
        {
            ListClientInteractions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateClientInteractionParams value) => new Params((global::ElevenLabs.CreateClientInteractionParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateClientInteractionParams?(Params @this) => @this.CreateClientInteraction;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateClientInteractionParams? value)
        {
            CreateClientInteraction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteClientInteractionParams value) => new Params((global::ElevenLabs.DeleteClientInteractionParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteClientInteractionParams?(Params @this) => @this.DeleteClientInteraction;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteClientInteractionParams? value)
        {
            DeleteClientInteraction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Params(
            global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType? smbToolType,
            global::ElevenLabs.SearchClientsParams? searchClients,
            global::ElevenLabs.ListClientsParams? listClients,
            global::ElevenLabs.GetClientByPhoneParams? getClientByPhone,
            global::ElevenLabs.CreateClientParams? createClient,
            global::ElevenLabs.UpdateClientParams? updateClient,
            global::ElevenLabs.DeleteClientParams? deleteClient,
            global::ElevenLabs.ListStaffParams? listStaff,
            global::ElevenLabs.CreateStaffParams? createStaff,
            global::ElevenLabs.UpdateStaffParams? updateStaff,
            global::ElevenLabs.DeleteStaffParams? deleteStaff,
            global::ElevenLabs.ListAssetsParams? listAssets,
            global::ElevenLabs.CreateAssetParams? createAsset,
            global::ElevenLabs.UpdateAssetParams? updateAsset,
            global::ElevenLabs.DeleteAssetParams? deleteAsset,
            global::ElevenLabs.ListServicesParams? listServices,
            global::ElevenLabs.CreateServiceParams? createService,
            global::ElevenLabs.UpdateServiceParams? updateService,
            global::ElevenLabs.DeleteServiceParams? deleteService,
            global::ElevenLabs.ListProductsParams? listProducts,
            global::ElevenLabs.CreateProductParams? createProduct,
            global::ElevenLabs.UpdateProductParams? updateProduct,
            global::ElevenLabs.DeleteProductParams? deleteProduct,
            global::ElevenLabs.CheckServiceAvailabilityParams? checkServiceAvailability,
            global::ElevenLabs.CreateClientAppointmentParams? createClientAppointment,
            global::ElevenLabs.GetClientAppointmentsParams? getClientAppointments,
            global::ElevenLabs.ListCalendarEventsParams? listCalendarEvents,
            global::ElevenLabs.UpdateCalendarEventParams? updateCalendarEvent,
            global::ElevenLabs.DeleteCalendarEventParams? deleteCalendarEvent,
            global::ElevenLabs.ListRentalServicesParams? listRentalServices,
            global::ElevenLabs.CreateRentalServiceParams? createRentalService,
            global::ElevenLabs.UpdateRentalServiceParams? updateRentalService,
            global::ElevenLabs.DeleteRentalServiceParams? deleteRentalService,
            global::ElevenLabs.CheckRentalAvailabilityParams? checkRentalAvailability,
            global::ElevenLabs.CreateRentalBookingParams? createRentalBooking,
            global::ElevenLabs.ListAgentRulesParams? listAgentRules,
            global::ElevenLabs.CreateAgentRuleParams? createAgentRule,
            global::ElevenLabs.UpdateAgentRuleParams? updateAgentRule,
            global::ElevenLabs.DeleteAgentRuleParams? deleteAgentRule,
            global::ElevenLabs.ListHolidaysParams? listHolidays,
            global::ElevenLabs.CreateHolidayParams? createHoliday,
            global::ElevenLabs.UpdateHolidayParams? updateHoliday,
            global::ElevenLabs.DeleteHolidayParams? deleteHoliday,
            global::ElevenLabs.GetScheduleParams? getSchedule,
            global::ElevenLabs.UpdateBusinessInfoParams? updateBusinessInfo,
            global::ElevenLabs.UpdateCustomerFacingConfigParams? updateCustomerFacingConfig,
            global::ElevenLabs.GetAnalyticsSummaryParams? getAnalyticsSummary,
            global::ElevenLabs.GetBookingPageSettingsParams? getBookingPageSettings,
            global::ElevenLabs.UpdateBookingPageSettingsParams? updateBookingPageSettings,
            global::ElevenLabs.GetBookingSlugStatusParams? getBookingSlugStatus,
            global::ElevenLabs.SetBookingSlugParams? setBookingSlug,
            global::ElevenLabs.ListClientInteractionsParams? listClientInteractions,
            global::ElevenLabs.CreateClientInteractionParams? createClientInteraction,
            global::ElevenLabs.DeleteClientInteractionParams? deleteClientInteraction
            )
        {
            SmbToolType = smbToolType;

            SearchClients = searchClients;
            ListClients = listClients;
            GetClientByPhone = getClientByPhone;
            CreateClient = createClient;
            UpdateClient = updateClient;
            DeleteClient = deleteClient;
            ListStaff = listStaff;
            CreateStaff = createStaff;
            UpdateStaff = updateStaff;
            DeleteStaff = deleteStaff;
            ListAssets = listAssets;
            CreateAsset = createAsset;
            UpdateAsset = updateAsset;
            DeleteAsset = deleteAsset;
            ListServices = listServices;
            CreateService = createService;
            UpdateService = updateService;
            DeleteService = deleteService;
            ListProducts = listProducts;
            CreateProduct = createProduct;
            UpdateProduct = updateProduct;
            DeleteProduct = deleteProduct;
            CheckServiceAvailability = checkServiceAvailability;
            CreateClientAppointment = createClientAppointment;
            GetClientAppointments = getClientAppointments;
            ListCalendarEvents = listCalendarEvents;
            UpdateCalendarEvent = updateCalendarEvent;
            DeleteCalendarEvent = deleteCalendarEvent;
            ListRentalServices = listRentalServices;
            CreateRentalService = createRentalService;
            UpdateRentalService = updateRentalService;
            DeleteRentalService = deleteRentalService;
            CheckRentalAvailability = checkRentalAvailability;
            CreateRentalBooking = createRentalBooking;
            ListAgentRules = listAgentRules;
            CreateAgentRule = createAgentRule;
            UpdateAgentRule = updateAgentRule;
            DeleteAgentRule = deleteAgentRule;
            ListHolidays = listHolidays;
            CreateHoliday = createHoliday;
            UpdateHoliday = updateHoliday;
            DeleteHoliday = deleteHoliday;
            GetSchedule = getSchedule;
            UpdateBusinessInfo = updateBusinessInfo;
            UpdateCustomerFacingConfig = updateCustomerFacingConfig;
            GetAnalyticsSummary = getAnalyticsSummary;
            GetBookingPageSettings = getBookingPageSettings;
            UpdateBookingPageSettings = updateBookingPageSettings;
            GetBookingSlugStatus = getBookingSlugStatus;
            SetBookingSlug = setBookingSlug;
            ListClientInteractions = listClientInteractions;
            CreateClientInteraction = createClientInteraction;
            DeleteClientInteraction = deleteClientInteraction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DeleteClientInteraction as object ??
            CreateClientInteraction as object ??
            ListClientInteractions as object ??
            SetBookingSlug as object ??
            GetBookingSlugStatus as object ??
            UpdateBookingPageSettings as object ??
            GetBookingPageSettings as object ??
            GetAnalyticsSummary as object ??
            UpdateCustomerFacingConfig as object ??
            UpdateBusinessInfo as object ??
            GetSchedule as object ??
            DeleteHoliday as object ??
            UpdateHoliday as object ??
            CreateHoliday as object ??
            ListHolidays as object ??
            DeleteAgentRule as object ??
            UpdateAgentRule as object ??
            CreateAgentRule as object ??
            ListAgentRules as object ??
            CreateRentalBooking as object ??
            CheckRentalAvailability as object ??
            DeleteRentalService as object ??
            UpdateRentalService as object ??
            CreateRentalService as object ??
            ListRentalServices as object ??
            DeleteCalendarEvent as object ??
            UpdateCalendarEvent as object ??
            ListCalendarEvents as object ??
            GetClientAppointments as object ??
            CreateClientAppointment as object ??
            CheckServiceAvailability as object ??
            DeleteProduct as object ??
            UpdateProduct as object ??
            CreateProduct as object ??
            ListProducts as object ??
            DeleteService as object ??
            UpdateService as object ??
            CreateService as object ??
            ListServices as object ??
            DeleteAsset as object ??
            UpdateAsset as object ??
            CreateAsset as object ??
            ListAssets as object ??
            DeleteStaff as object ??
            UpdateStaff as object ??
            CreateStaff as object ??
            ListStaff as object ??
            DeleteClient as object ??
            UpdateClient as object ??
            CreateClient as object ??
            GetClientByPhone as object ??
            ListClients as object ??
            SearchClients as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchClients?.ToString() ??
            ListClients?.ToString() ??
            GetClientByPhone?.ToString() ??
            CreateClient?.ToString() ??
            UpdateClient?.ToString() ??
            DeleteClient?.ToString() ??
            ListStaff?.ToString() ??
            CreateStaff?.ToString() ??
            UpdateStaff?.ToString() ??
            DeleteStaff?.ToString() ??
            ListAssets?.ToString() ??
            CreateAsset?.ToString() ??
            UpdateAsset?.ToString() ??
            DeleteAsset?.ToString() ??
            ListServices?.ToString() ??
            CreateService?.ToString() ??
            UpdateService?.ToString() ??
            DeleteService?.ToString() ??
            ListProducts?.ToString() ??
            CreateProduct?.ToString() ??
            UpdateProduct?.ToString() ??
            DeleteProduct?.ToString() ??
            CheckServiceAvailability?.ToString() ??
            CreateClientAppointment?.ToString() ??
            GetClientAppointments?.ToString() ??
            ListCalendarEvents?.ToString() ??
            UpdateCalendarEvent?.ToString() ??
            DeleteCalendarEvent?.ToString() ??
            ListRentalServices?.ToString() ??
            CreateRentalService?.ToString() ??
            UpdateRentalService?.ToString() ??
            DeleteRentalService?.ToString() ??
            CheckRentalAvailability?.ToString() ??
            CreateRentalBooking?.ToString() ??
            ListAgentRules?.ToString() ??
            CreateAgentRule?.ToString() ??
            UpdateAgentRule?.ToString() ??
            DeleteAgentRule?.ToString() ??
            ListHolidays?.ToString() ??
            CreateHoliday?.ToString() ??
            UpdateHoliday?.ToString() ??
            DeleteHoliday?.ToString() ??
            GetSchedule?.ToString() ??
            UpdateBusinessInfo?.ToString() ??
            UpdateCustomerFacingConfig?.ToString() ??
            GetAnalyticsSummary?.ToString() ??
            GetBookingPageSettings?.ToString() ??
            UpdateBookingPageSettings?.ToString() ??
            GetBookingSlugStatus?.ToString() ??
            SetBookingSlug?.ToString() ??
            ListClientInteractions?.ToString() ??
            CreateClientInteraction?.ToString() ??
            DeleteClientInteraction?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && IsCreateClientInteraction && !IsDeleteClientInteraction || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCreateRentalService && !IsUpdateRentalService && !IsDeleteRentalService && !IsCheckRentalAvailability && !IsCreateRentalBooking && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && IsDeleteClientInteraction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.SearchClientsParams?, TResult>? searchClients = null,
            global::System.Func<global::ElevenLabs.ListClientsParams?, TResult>? listClients = null,
            global::System.Func<global::ElevenLabs.GetClientByPhoneParams?, TResult>? getClientByPhone = null,
            global::System.Func<global::ElevenLabs.CreateClientParams?, TResult>? createClient = null,
            global::System.Func<global::ElevenLabs.UpdateClientParams?, TResult>? updateClient = null,
            global::System.Func<global::ElevenLabs.DeleteClientParams?, TResult>? deleteClient = null,
            global::System.Func<global::ElevenLabs.ListStaffParams?, TResult>? listStaff = null,
            global::System.Func<global::ElevenLabs.CreateStaffParams?, TResult>? createStaff = null,
            global::System.Func<global::ElevenLabs.UpdateStaffParams?, TResult>? updateStaff = null,
            global::System.Func<global::ElevenLabs.DeleteStaffParams?, TResult>? deleteStaff = null,
            global::System.Func<global::ElevenLabs.ListAssetsParams?, TResult>? listAssets = null,
            global::System.Func<global::ElevenLabs.CreateAssetParams?, TResult>? createAsset = null,
            global::System.Func<global::ElevenLabs.UpdateAssetParams?, TResult>? updateAsset = null,
            global::System.Func<global::ElevenLabs.DeleteAssetParams?, TResult>? deleteAsset = null,
            global::System.Func<global::ElevenLabs.ListServicesParams?, TResult>? listServices = null,
            global::System.Func<global::ElevenLabs.CreateServiceParams?, TResult>? createService = null,
            global::System.Func<global::ElevenLabs.UpdateServiceParams?, TResult>? updateService = null,
            global::System.Func<global::ElevenLabs.DeleteServiceParams?, TResult>? deleteService = null,
            global::System.Func<global::ElevenLabs.ListProductsParams?, TResult>? listProducts = null,
            global::System.Func<global::ElevenLabs.CreateProductParams?, TResult>? createProduct = null,
            global::System.Func<global::ElevenLabs.UpdateProductParams?, TResult>? updateProduct = null,
            global::System.Func<global::ElevenLabs.DeleteProductParams?, TResult>? deleteProduct = null,
            global::System.Func<global::ElevenLabs.CheckServiceAvailabilityParams?, TResult>? checkServiceAvailability = null,
            global::System.Func<global::ElevenLabs.CreateClientAppointmentParams?, TResult>? createClientAppointment = null,
            global::System.Func<global::ElevenLabs.GetClientAppointmentsParams?, TResult>? getClientAppointments = null,
            global::System.Func<global::ElevenLabs.ListCalendarEventsParams?, TResult>? listCalendarEvents = null,
            global::System.Func<global::ElevenLabs.UpdateCalendarEventParams?, TResult>? updateCalendarEvent = null,
            global::System.Func<global::ElevenLabs.DeleteCalendarEventParams?, TResult>? deleteCalendarEvent = null,
            global::System.Func<global::ElevenLabs.ListRentalServicesParams?, TResult>? listRentalServices = null,
            global::System.Func<global::ElevenLabs.CreateRentalServiceParams?, TResult>? createRentalService = null,
            global::System.Func<global::ElevenLabs.UpdateRentalServiceParams?, TResult>? updateRentalService = null,
            global::System.Func<global::ElevenLabs.DeleteRentalServiceParams?, TResult>? deleteRentalService = null,
            global::System.Func<global::ElevenLabs.CheckRentalAvailabilityParams?, TResult>? checkRentalAvailability = null,
            global::System.Func<global::ElevenLabs.CreateRentalBookingParams?, TResult>? createRentalBooking = null,
            global::System.Func<global::ElevenLabs.ListAgentRulesParams?, TResult>? listAgentRules = null,
            global::System.Func<global::ElevenLabs.CreateAgentRuleParams?, TResult>? createAgentRule = null,
            global::System.Func<global::ElevenLabs.UpdateAgentRuleParams?, TResult>? updateAgentRule = null,
            global::System.Func<global::ElevenLabs.DeleteAgentRuleParams?, TResult>? deleteAgentRule = null,
            global::System.Func<global::ElevenLabs.ListHolidaysParams?, TResult>? listHolidays = null,
            global::System.Func<global::ElevenLabs.CreateHolidayParams?, TResult>? createHoliday = null,
            global::System.Func<global::ElevenLabs.UpdateHolidayParams?, TResult>? updateHoliday = null,
            global::System.Func<global::ElevenLabs.DeleteHolidayParams?, TResult>? deleteHoliday = null,
            global::System.Func<global::ElevenLabs.GetScheduleParams?, TResult>? getSchedule = null,
            global::System.Func<global::ElevenLabs.UpdateBusinessInfoParams?, TResult>? updateBusinessInfo = null,
            global::System.Func<global::ElevenLabs.UpdateCustomerFacingConfigParams?, TResult>? updateCustomerFacingConfig = null,
            global::System.Func<global::ElevenLabs.GetAnalyticsSummaryParams?, TResult>? getAnalyticsSummary = null,
            global::System.Func<global::ElevenLabs.GetBookingPageSettingsParams?, TResult>? getBookingPageSettings = null,
            global::System.Func<global::ElevenLabs.UpdateBookingPageSettingsParams?, TResult>? updateBookingPageSettings = null,
            global::System.Func<global::ElevenLabs.GetBookingSlugStatusParams?, TResult>? getBookingSlugStatus = null,
            global::System.Func<global::ElevenLabs.SetBookingSlugParams?, TResult>? setBookingSlug = null,
            global::System.Func<global::ElevenLabs.ListClientInteractionsParams?, TResult>? listClientInteractions = null,
            global::System.Func<global::ElevenLabs.CreateClientInteractionParams?, TResult>? createClientInteraction = null,
            global::System.Func<global::ElevenLabs.DeleteClientInteractionParams?, TResult>? deleteClientInteraction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchClients && searchClients != null)
            {
                return searchClients(SearchClients!);
            }
            else if (IsListClients && listClients != null)
            {
                return listClients(ListClients!);
            }
            else if (IsGetClientByPhone && getClientByPhone != null)
            {
                return getClientByPhone(GetClientByPhone!);
            }
            else if (IsCreateClient && createClient != null)
            {
                return createClient(CreateClient!);
            }
            else if (IsUpdateClient && updateClient != null)
            {
                return updateClient(UpdateClient!);
            }
            else if (IsDeleteClient && deleteClient != null)
            {
                return deleteClient(DeleteClient!);
            }
            else if (IsListStaff && listStaff != null)
            {
                return listStaff(ListStaff!);
            }
            else if (IsCreateStaff && createStaff != null)
            {
                return createStaff(CreateStaff!);
            }
            else if (IsUpdateStaff && updateStaff != null)
            {
                return updateStaff(UpdateStaff!);
            }
            else if (IsDeleteStaff && deleteStaff != null)
            {
                return deleteStaff(DeleteStaff!);
            }
            else if (IsListAssets && listAssets != null)
            {
                return listAssets(ListAssets!);
            }
            else if (IsCreateAsset && createAsset != null)
            {
                return createAsset(CreateAsset!);
            }
            else if (IsUpdateAsset && updateAsset != null)
            {
                return updateAsset(UpdateAsset!);
            }
            else if (IsDeleteAsset && deleteAsset != null)
            {
                return deleteAsset(DeleteAsset!);
            }
            else if (IsListServices && listServices != null)
            {
                return listServices(ListServices!);
            }
            else if (IsCreateService && createService != null)
            {
                return createService(CreateService!);
            }
            else if (IsUpdateService && updateService != null)
            {
                return updateService(UpdateService!);
            }
            else if (IsDeleteService && deleteService != null)
            {
                return deleteService(DeleteService!);
            }
            else if (IsListProducts && listProducts != null)
            {
                return listProducts(ListProducts!);
            }
            else if (IsCreateProduct && createProduct != null)
            {
                return createProduct(CreateProduct!);
            }
            else if (IsUpdateProduct && updateProduct != null)
            {
                return updateProduct(UpdateProduct!);
            }
            else if (IsDeleteProduct && deleteProduct != null)
            {
                return deleteProduct(DeleteProduct!);
            }
            else if (IsCheckServiceAvailability && checkServiceAvailability != null)
            {
                return checkServiceAvailability(CheckServiceAvailability!);
            }
            else if (IsCreateClientAppointment && createClientAppointment != null)
            {
                return createClientAppointment(CreateClientAppointment!);
            }
            else if (IsGetClientAppointments && getClientAppointments != null)
            {
                return getClientAppointments(GetClientAppointments!);
            }
            else if (IsListCalendarEvents && listCalendarEvents != null)
            {
                return listCalendarEvents(ListCalendarEvents!);
            }
            else if (IsUpdateCalendarEvent && updateCalendarEvent != null)
            {
                return updateCalendarEvent(UpdateCalendarEvent!);
            }
            else if (IsDeleteCalendarEvent && deleteCalendarEvent != null)
            {
                return deleteCalendarEvent(DeleteCalendarEvent!);
            }
            else if (IsListRentalServices && listRentalServices != null)
            {
                return listRentalServices(ListRentalServices!);
            }
            else if (IsCreateRentalService && createRentalService != null)
            {
                return createRentalService(CreateRentalService!);
            }
            else if (IsUpdateRentalService && updateRentalService != null)
            {
                return updateRentalService(UpdateRentalService!);
            }
            else if (IsDeleteRentalService && deleteRentalService != null)
            {
                return deleteRentalService(DeleteRentalService!);
            }
            else if (IsCheckRentalAvailability && checkRentalAvailability != null)
            {
                return checkRentalAvailability(CheckRentalAvailability!);
            }
            else if (IsCreateRentalBooking && createRentalBooking != null)
            {
                return createRentalBooking(CreateRentalBooking!);
            }
            else if (IsListAgentRules && listAgentRules != null)
            {
                return listAgentRules(ListAgentRules!);
            }
            else if (IsCreateAgentRule && createAgentRule != null)
            {
                return createAgentRule(CreateAgentRule!);
            }
            else if (IsUpdateAgentRule && updateAgentRule != null)
            {
                return updateAgentRule(UpdateAgentRule!);
            }
            else if (IsDeleteAgentRule && deleteAgentRule != null)
            {
                return deleteAgentRule(DeleteAgentRule!);
            }
            else if (IsListHolidays && listHolidays != null)
            {
                return listHolidays(ListHolidays!);
            }
            else if (IsCreateHoliday && createHoliday != null)
            {
                return createHoliday(CreateHoliday!);
            }
            else if (IsUpdateHoliday && updateHoliday != null)
            {
                return updateHoliday(UpdateHoliday!);
            }
            else if (IsDeleteHoliday && deleteHoliday != null)
            {
                return deleteHoliday(DeleteHoliday!);
            }
            else if (IsGetSchedule && getSchedule != null)
            {
                return getSchedule(GetSchedule!);
            }
            else if (IsUpdateBusinessInfo && updateBusinessInfo != null)
            {
                return updateBusinessInfo(UpdateBusinessInfo!);
            }
            else if (IsUpdateCustomerFacingConfig && updateCustomerFacingConfig != null)
            {
                return updateCustomerFacingConfig(UpdateCustomerFacingConfig!);
            }
            else if (IsGetAnalyticsSummary && getAnalyticsSummary != null)
            {
                return getAnalyticsSummary(GetAnalyticsSummary!);
            }
            else if (IsGetBookingPageSettings && getBookingPageSettings != null)
            {
                return getBookingPageSettings(GetBookingPageSettings!);
            }
            else if (IsUpdateBookingPageSettings && updateBookingPageSettings != null)
            {
                return updateBookingPageSettings(UpdateBookingPageSettings!);
            }
            else if (IsGetBookingSlugStatus && getBookingSlugStatus != null)
            {
                return getBookingSlugStatus(GetBookingSlugStatus!);
            }
            else if (IsSetBookingSlug && setBookingSlug != null)
            {
                return setBookingSlug(SetBookingSlug!);
            }
            else if (IsListClientInteractions && listClientInteractions != null)
            {
                return listClientInteractions(ListClientInteractions!);
            }
            else if (IsCreateClientInteraction && createClientInteraction != null)
            {
                return createClientInteraction(CreateClientInteraction!);
            }
            else if (IsDeleteClientInteraction && deleteClientInteraction != null)
            {
                return deleteClientInteraction(DeleteClientInteraction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.SearchClientsParams?>? searchClients = null,
            global::System.Action<global::ElevenLabs.ListClientsParams?>? listClients = null,
            global::System.Action<global::ElevenLabs.GetClientByPhoneParams?>? getClientByPhone = null,
            global::System.Action<global::ElevenLabs.CreateClientParams?>? createClient = null,
            global::System.Action<global::ElevenLabs.UpdateClientParams?>? updateClient = null,
            global::System.Action<global::ElevenLabs.DeleteClientParams?>? deleteClient = null,
            global::System.Action<global::ElevenLabs.ListStaffParams?>? listStaff = null,
            global::System.Action<global::ElevenLabs.CreateStaffParams?>? createStaff = null,
            global::System.Action<global::ElevenLabs.UpdateStaffParams?>? updateStaff = null,
            global::System.Action<global::ElevenLabs.DeleteStaffParams?>? deleteStaff = null,
            global::System.Action<global::ElevenLabs.ListAssetsParams?>? listAssets = null,
            global::System.Action<global::ElevenLabs.CreateAssetParams?>? createAsset = null,
            global::System.Action<global::ElevenLabs.UpdateAssetParams?>? updateAsset = null,
            global::System.Action<global::ElevenLabs.DeleteAssetParams?>? deleteAsset = null,
            global::System.Action<global::ElevenLabs.ListServicesParams?>? listServices = null,
            global::System.Action<global::ElevenLabs.CreateServiceParams?>? createService = null,
            global::System.Action<global::ElevenLabs.UpdateServiceParams?>? updateService = null,
            global::System.Action<global::ElevenLabs.DeleteServiceParams?>? deleteService = null,
            global::System.Action<global::ElevenLabs.ListProductsParams?>? listProducts = null,
            global::System.Action<global::ElevenLabs.CreateProductParams?>? createProduct = null,
            global::System.Action<global::ElevenLabs.UpdateProductParams?>? updateProduct = null,
            global::System.Action<global::ElevenLabs.DeleteProductParams?>? deleteProduct = null,
            global::System.Action<global::ElevenLabs.CheckServiceAvailabilityParams?>? checkServiceAvailability = null,
            global::System.Action<global::ElevenLabs.CreateClientAppointmentParams?>? createClientAppointment = null,
            global::System.Action<global::ElevenLabs.GetClientAppointmentsParams?>? getClientAppointments = null,
            global::System.Action<global::ElevenLabs.ListCalendarEventsParams?>? listCalendarEvents = null,
            global::System.Action<global::ElevenLabs.UpdateCalendarEventParams?>? updateCalendarEvent = null,
            global::System.Action<global::ElevenLabs.DeleteCalendarEventParams?>? deleteCalendarEvent = null,
            global::System.Action<global::ElevenLabs.ListRentalServicesParams?>? listRentalServices = null,
            global::System.Action<global::ElevenLabs.CreateRentalServiceParams?>? createRentalService = null,
            global::System.Action<global::ElevenLabs.UpdateRentalServiceParams?>? updateRentalService = null,
            global::System.Action<global::ElevenLabs.DeleteRentalServiceParams?>? deleteRentalService = null,
            global::System.Action<global::ElevenLabs.CheckRentalAvailabilityParams?>? checkRentalAvailability = null,
            global::System.Action<global::ElevenLabs.CreateRentalBookingParams?>? createRentalBooking = null,
            global::System.Action<global::ElevenLabs.ListAgentRulesParams?>? listAgentRules = null,
            global::System.Action<global::ElevenLabs.CreateAgentRuleParams?>? createAgentRule = null,
            global::System.Action<global::ElevenLabs.UpdateAgentRuleParams?>? updateAgentRule = null,
            global::System.Action<global::ElevenLabs.DeleteAgentRuleParams?>? deleteAgentRule = null,
            global::System.Action<global::ElevenLabs.ListHolidaysParams?>? listHolidays = null,
            global::System.Action<global::ElevenLabs.CreateHolidayParams?>? createHoliday = null,
            global::System.Action<global::ElevenLabs.UpdateHolidayParams?>? updateHoliday = null,
            global::System.Action<global::ElevenLabs.DeleteHolidayParams?>? deleteHoliday = null,
            global::System.Action<global::ElevenLabs.GetScheduleParams?>? getSchedule = null,
            global::System.Action<global::ElevenLabs.UpdateBusinessInfoParams?>? updateBusinessInfo = null,
            global::System.Action<global::ElevenLabs.UpdateCustomerFacingConfigParams?>? updateCustomerFacingConfig = null,
            global::System.Action<global::ElevenLabs.GetAnalyticsSummaryParams?>? getAnalyticsSummary = null,
            global::System.Action<global::ElevenLabs.GetBookingPageSettingsParams?>? getBookingPageSettings = null,
            global::System.Action<global::ElevenLabs.UpdateBookingPageSettingsParams?>? updateBookingPageSettings = null,
            global::System.Action<global::ElevenLabs.GetBookingSlugStatusParams?>? getBookingSlugStatus = null,
            global::System.Action<global::ElevenLabs.SetBookingSlugParams?>? setBookingSlug = null,
            global::System.Action<global::ElevenLabs.ListClientInteractionsParams?>? listClientInteractions = null,
            global::System.Action<global::ElevenLabs.CreateClientInteractionParams?>? createClientInteraction = null,
            global::System.Action<global::ElevenLabs.DeleteClientInteractionParams?>? deleteClientInteraction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchClients)
            {
                searchClients?.Invoke(SearchClients!);
            }
            else if (IsListClients)
            {
                listClients?.Invoke(ListClients!);
            }
            else if (IsGetClientByPhone)
            {
                getClientByPhone?.Invoke(GetClientByPhone!);
            }
            else if (IsCreateClient)
            {
                createClient?.Invoke(CreateClient!);
            }
            else if (IsUpdateClient)
            {
                updateClient?.Invoke(UpdateClient!);
            }
            else if (IsDeleteClient)
            {
                deleteClient?.Invoke(DeleteClient!);
            }
            else if (IsListStaff)
            {
                listStaff?.Invoke(ListStaff!);
            }
            else if (IsCreateStaff)
            {
                createStaff?.Invoke(CreateStaff!);
            }
            else if (IsUpdateStaff)
            {
                updateStaff?.Invoke(UpdateStaff!);
            }
            else if (IsDeleteStaff)
            {
                deleteStaff?.Invoke(DeleteStaff!);
            }
            else if (IsListAssets)
            {
                listAssets?.Invoke(ListAssets!);
            }
            else if (IsCreateAsset)
            {
                createAsset?.Invoke(CreateAsset!);
            }
            else if (IsUpdateAsset)
            {
                updateAsset?.Invoke(UpdateAsset!);
            }
            else if (IsDeleteAsset)
            {
                deleteAsset?.Invoke(DeleteAsset!);
            }
            else if (IsListServices)
            {
                listServices?.Invoke(ListServices!);
            }
            else if (IsCreateService)
            {
                createService?.Invoke(CreateService!);
            }
            else if (IsUpdateService)
            {
                updateService?.Invoke(UpdateService!);
            }
            else if (IsDeleteService)
            {
                deleteService?.Invoke(DeleteService!);
            }
            else if (IsListProducts)
            {
                listProducts?.Invoke(ListProducts!);
            }
            else if (IsCreateProduct)
            {
                createProduct?.Invoke(CreateProduct!);
            }
            else if (IsUpdateProduct)
            {
                updateProduct?.Invoke(UpdateProduct!);
            }
            else if (IsDeleteProduct)
            {
                deleteProduct?.Invoke(DeleteProduct!);
            }
            else if (IsCheckServiceAvailability)
            {
                checkServiceAvailability?.Invoke(CheckServiceAvailability!);
            }
            else if (IsCreateClientAppointment)
            {
                createClientAppointment?.Invoke(CreateClientAppointment!);
            }
            else if (IsGetClientAppointments)
            {
                getClientAppointments?.Invoke(GetClientAppointments!);
            }
            else if (IsListCalendarEvents)
            {
                listCalendarEvents?.Invoke(ListCalendarEvents!);
            }
            else if (IsUpdateCalendarEvent)
            {
                updateCalendarEvent?.Invoke(UpdateCalendarEvent!);
            }
            else if (IsDeleteCalendarEvent)
            {
                deleteCalendarEvent?.Invoke(DeleteCalendarEvent!);
            }
            else if (IsListRentalServices)
            {
                listRentalServices?.Invoke(ListRentalServices!);
            }
            else if (IsCreateRentalService)
            {
                createRentalService?.Invoke(CreateRentalService!);
            }
            else if (IsUpdateRentalService)
            {
                updateRentalService?.Invoke(UpdateRentalService!);
            }
            else if (IsDeleteRentalService)
            {
                deleteRentalService?.Invoke(DeleteRentalService!);
            }
            else if (IsCheckRentalAvailability)
            {
                checkRentalAvailability?.Invoke(CheckRentalAvailability!);
            }
            else if (IsCreateRentalBooking)
            {
                createRentalBooking?.Invoke(CreateRentalBooking!);
            }
            else if (IsListAgentRules)
            {
                listAgentRules?.Invoke(ListAgentRules!);
            }
            else if (IsCreateAgentRule)
            {
                createAgentRule?.Invoke(CreateAgentRule!);
            }
            else if (IsUpdateAgentRule)
            {
                updateAgentRule?.Invoke(UpdateAgentRule!);
            }
            else if (IsDeleteAgentRule)
            {
                deleteAgentRule?.Invoke(DeleteAgentRule!);
            }
            else if (IsListHolidays)
            {
                listHolidays?.Invoke(ListHolidays!);
            }
            else if (IsCreateHoliday)
            {
                createHoliday?.Invoke(CreateHoliday!);
            }
            else if (IsUpdateHoliday)
            {
                updateHoliday?.Invoke(UpdateHoliday!);
            }
            else if (IsDeleteHoliday)
            {
                deleteHoliday?.Invoke(DeleteHoliday!);
            }
            else if (IsGetSchedule)
            {
                getSchedule?.Invoke(GetSchedule!);
            }
            else if (IsUpdateBusinessInfo)
            {
                updateBusinessInfo?.Invoke(UpdateBusinessInfo!);
            }
            else if (IsUpdateCustomerFacingConfig)
            {
                updateCustomerFacingConfig?.Invoke(UpdateCustomerFacingConfig!);
            }
            else if (IsGetAnalyticsSummary)
            {
                getAnalyticsSummary?.Invoke(GetAnalyticsSummary!);
            }
            else if (IsGetBookingPageSettings)
            {
                getBookingPageSettings?.Invoke(GetBookingPageSettings!);
            }
            else if (IsUpdateBookingPageSettings)
            {
                updateBookingPageSettings?.Invoke(UpdateBookingPageSettings!);
            }
            else if (IsGetBookingSlugStatus)
            {
                getBookingSlugStatus?.Invoke(GetBookingSlugStatus!);
            }
            else if (IsSetBookingSlug)
            {
                setBookingSlug?.Invoke(SetBookingSlug!);
            }
            else if (IsListClientInteractions)
            {
                listClientInteractions?.Invoke(ListClientInteractions!);
            }
            else if (IsCreateClientInteraction)
            {
                createClientInteraction?.Invoke(CreateClientInteraction!);
            }
            else if (IsDeleteClientInteraction)
            {
                deleteClientInteraction?.Invoke(DeleteClientInteraction!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchClients,
                typeof(global::ElevenLabs.SearchClientsParams),
                ListClients,
                typeof(global::ElevenLabs.ListClientsParams),
                GetClientByPhone,
                typeof(global::ElevenLabs.GetClientByPhoneParams),
                CreateClient,
                typeof(global::ElevenLabs.CreateClientParams),
                UpdateClient,
                typeof(global::ElevenLabs.UpdateClientParams),
                DeleteClient,
                typeof(global::ElevenLabs.DeleteClientParams),
                ListStaff,
                typeof(global::ElevenLabs.ListStaffParams),
                CreateStaff,
                typeof(global::ElevenLabs.CreateStaffParams),
                UpdateStaff,
                typeof(global::ElevenLabs.UpdateStaffParams),
                DeleteStaff,
                typeof(global::ElevenLabs.DeleteStaffParams),
                ListAssets,
                typeof(global::ElevenLabs.ListAssetsParams),
                CreateAsset,
                typeof(global::ElevenLabs.CreateAssetParams),
                UpdateAsset,
                typeof(global::ElevenLabs.UpdateAssetParams),
                DeleteAsset,
                typeof(global::ElevenLabs.DeleteAssetParams),
                ListServices,
                typeof(global::ElevenLabs.ListServicesParams),
                CreateService,
                typeof(global::ElevenLabs.CreateServiceParams),
                UpdateService,
                typeof(global::ElevenLabs.UpdateServiceParams),
                DeleteService,
                typeof(global::ElevenLabs.DeleteServiceParams),
                ListProducts,
                typeof(global::ElevenLabs.ListProductsParams),
                CreateProduct,
                typeof(global::ElevenLabs.CreateProductParams),
                UpdateProduct,
                typeof(global::ElevenLabs.UpdateProductParams),
                DeleteProduct,
                typeof(global::ElevenLabs.DeleteProductParams),
                CheckServiceAvailability,
                typeof(global::ElevenLabs.CheckServiceAvailabilityParams),
                CreateClientAppointment,
                typeof(global::ElevenLabs.CreateClientAppointmentParams),
                GetClientAppointments,
                typeof(global::ElevenLabs.GetClientAppointmentsParams),
                ListCalendarEvents,
                typeof(global::ElevenLabs.ListCalendarEventsParams),
                UpdateCalendarEvent,
                typeof(global::ElevenLabs.UpdateCalendarEventParams),
                DeleteCalendarEvent,
                typeof(global::ElevenLabs.DeleteCalendarEventParams),
                ListRentalServices,
                typeof(global::ElevenLabs.ListRentalServicesParams),
                CreateRentalService,
                typeof(global::ElevenLabs.CreateRentalServiceParams),
                UpdateRentalService,
                typeof(global::ElevenLabs.UpdateRentalServiceParams),
                DeleteRentalService,
                typeof(global::ElevenLabs.DeleteRentalServiceParams),
                CheckRentalAvailability,
                typeof(global::ElevenLabs.CheckRentalAvailabilityParams),
                CreateRentalBooking,
                typeof(global::ElevenLabs.CreateRentalBookingParams),
                ListAgentRules,
                typeof(global::ElevenLabs.ListAgentRulesParams),
                CreateAgentRule,
                typeof(global::ElevenLabs.CreateAgentRuleParams),
                UpdateAgentRule,
                typeof(global::ElevenLabs.UpdateAgentRuleParams),
                DeleteAgentRule,
                typeof(global::ElevenLabs.DeleteAgentRuleParams),
                ListHolidays,
                typeof(global::ElevenLabs.ListHolidaysParams),
                CreateHoliday,
                typeof(global::ElevenLabs.CreateHolidayParams),
                UpdateHoliday,
                typeof(global::ElevenLabs.UpdateHolidayParams),
                DeleteHoliday,
                typeof(global::ElevenLabs.DeleteHolidayParams),
                GetSchedule,
                typeof(global::ElevenLabs.GetScheduleParams),
                UpdateBusinessInfo,
                typeof(global::ElevenLabs.UpdateBusinessInfoParams),
                UpdateCustomerFacingConfig,
                typeof(global::ElevenLabs.UpdateCustomerFacingConfigParams),
                GetAnalyticsSummary,
                typeof(global::ElevenLabs.GetAnalyticsSummaryParams),
                GetBookingPageSettings,
                typeof(global::ElevenLabs.GetBookingPageSettingsParams),
                UpdateBookingPageSettings,
                typeof(global::ElevenLabs.UpdateBookingPageSettingsParams),
                GetBookingSlugStatus,
                typeof(global::ElevenLabs.GetBookingSlugStatusParams),
                SetBookingSlug,
                typeof(global::ElevenLabs.SetBookingSlugParams),
                ListClientInteractions,
                typeof(global::ElevenLabs.ListClientInteractionsParams),
                CreateClientInteraction,
                typeof(global::ElevenLabs.CreateClientInteractionParams),
                DeleteClientInteraction,
                typeof(global::ElevenLabs.DeleteClientInteractionParams),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Params other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SearchClientsParams?>.Default.Equals(SearchClients, other.SearchClients) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListClientsParams?>.Default.Equals(ListClients, other.ListClients) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetClientByPhoneParams?>.Default.Equals(GetClientByPhone, other.GetClientByPhone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateClientParams?>.Default.Equals(CreateClient, other.CreateClient) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateClientParams?>.Default.Equals(UpdateClient, other.UpdateClient) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteClientParams?>.Default.Equals(DeleteClient, other.DeleteClient) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListStaffParams?>.Default.Equals(ListStaff, other.ListStaff) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateStaffParams?>.Default.Equals(CreateStaff, other.CreateStaff) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateStaffParams?>.Default.Equals(UpdateStaff, other.UpdateStaff) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteStaffParams?>.Default.Equals(DeleteStaff, other.DeleteStaff) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListAssetsParams?>.Default.Equals(ListAssets, other.ListAssets) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateAssetParams?>.Default.Equals(CreateAsset, other.CreateAsset) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateAssetParams?>.Default.Equals(UpdateAsset, other.UpdateAsset) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteAssetParams?>.Default.Equals(DeleteAsset, other.DeleteAsset) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListServicesParams?>.Default.Equals(ListServices, other.ListServices) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateServiceParams?>.Default.Equals(CreateService, other.CreateService) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateServiceParams?>.Default.Equals(UpdateService, other.UpdateService) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteServiceParams?>.Default.Equals(DeleteService, other.DeleteService) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListProductsParams?>.Default.Equals(ListProducts, other.ListProducts) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateProductParams?>.Default.Equals(CreateProduct, other.CreateProduct) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateProductParams?>.Default.Equals(UpdateProduct, other.UpdateProduct) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteProductParams?>.Default.Equals(DeleteProduct, other.DeleteProduct) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CheckServiceAvailabilityParams?>.Default.Equals(CheckServiceAvailability, other.CheckServiceAvailability) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateClientAppointmentParams?>.Default.Equals(CreateClientAppointment, other.CreateClientAppointment) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetClientAppointmentsParams?>.Default.Equals(GetClientAppointments, other.GetClientAppointments) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListCalendarEventsParams?>.Default.Equals(ListCalendarEvents, other.ListCalendarEvents) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateCalendarEventParams?>.Default.Equals(UpdateCalendarEvent, other.UpdateCalendarEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteCalendarEventParams?>.Default.Equals(DeleteCalendarEvent, other.DeleteCalendarEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListRentalServicesParams?>.Default.Equals(ListRentalServices, other.ListRentalServices) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateRentalServiceParams?>.Default.Equals(CreateRentalService, other.CreateRentalService) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateRentalServiceParams?>.Default.Equals(UpdateRentalService, other.UpdateRentalService) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteRentalServiceParams?>.Default.Equals(DeleteRentalService, other.DeleteRentalService) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CheckRentalAvailabilityParams?>.Default.Equals(CheckRentalAvailability, other.CheckRentalAvailability) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateRentalBookingParams?>.Default.Equals(CreateRentalBooking, other.CreateRentalBooking) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListAgentRulesParams?>.Default.Equals(ListAgentRules, other.ListAgentRules) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateAgentRuleParams?>.Default.Equals(CreateAgentRule, other.CreateAgentRule) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateAgentRuleParams?>.Default.Equals(UpdateAgentRule, other.UpdateAgentRule) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteAgentRuleParams?>.Default.Equals(DeleteAgentRule, other.DeleteAgentRule) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListHolidaysParams?>.Default.Equals(ListHolidays, other.ListHolidays) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateHolidayParams?>.Default.Equals(CreateHoliday, other.CreateHoliday) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateHolidayParams?>.Default.Equals(UpdateHoliday, other.UpdateHoliday) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteHolidayParams?>.Default.Equals(DeleteHoliday, other.DeleteHoliday) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetScheduleParams?>.Default.Equals(GetSchedule, other.GetSchedule) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateBusinessInfoParams?>.Default.Equals(UpdateBusinessInfo, other.UpdateBusinessInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateCustomerFacingConfigParams?>.Default.Equals(UpdateCustomerFacingConfig, other.UpdateCustomerFacingConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetAnalyticsSummaryParams?>.Default.Equals(GetAnalyticsSummary, other.GetAnalyticsSummary) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetBookingPageSettingsParams?>.Default.Equals(GetBookingPageSettings, other.GetBookingPageSettings) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateBookingPageSettingsParams?>.Default.Equals(UpdateBookingPageSettings, other.UpdateBookingPageSettings) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetBookingSlugStatusParams?>.Default.Equals(GetBookingSlugStatus, other.GetBookingSlugStatus) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SetBookingSlugParams?>.Default.Equals(SetBookingSlug, other.SetBookingSlug) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListClientInteractionsParams?>.Default.Equals(ListClientInteractions, other.ListClientInteractions) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateClientInteractionParams?>.Default.Equals(CreateClientInteraction, other.CreateClientInteraction) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteClientInteractionParams?>.Default.Equals(DeleteClientInteraction, other.DeleteClientInteraction) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Params obj1, Params obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Params>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Params obj1, Params obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Params o && Equals(o);
        }
    }
}
