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
        /// 
        /// </summary>
        public bool TryPickSearchClients(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SearchClientsParams? value)
        {
            value = SearchClients;
            return IsSearchClients;
        }

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
        /// 
        /// </summary>
        public bool TryPickListClients(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListClientsParams? value)
        {
            value = ListClients;
            return IsListClients;
        }

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
        /// 
        /// </summary>
        public bool TryPickGetClientByPhone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetClientByPhoneParams? value)
        {
            value = GetClientByPhone;
            return IsGetClientByPhone;
        }

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
        /// 
        /// </summary>
        public bool TryPickCreateClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateClientParams? value)
        {
            value = CreateClient;
            return IsCreateClient;
        }

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
        /// 
        /// </summary>
        public bool TryPickUpdateClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateClientParams? value)
        {
            value = UpdateClient;
            return IsUpdateClient;
        }

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
        public bool TryPickDeleteClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteClientParams? value)
        {
            value = DeleteClient;
            return IsDeleteClient;
        }

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
        /// 
        /// </summary>
        public bool TryPickListStaff(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListStaffParams? value)
        {
            value = ListStaff;
            return IsListStaff;
        }

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
        /// 
        /// </summary>
        public bool TryPickCreateStaff(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateStaffParams? value)
        {
            value = CreateStaff;
            return IsCreateStaff;
        }

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
        /// 
        /// </summary>
        public bool TryPickUpdateStaff(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateStaffParams? value)
        {
            value = UpdateStaff;
            return IsUpdateStaff;
        }

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
        public bool TryPickDeleteStaff(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteStaffParams? value)
        {
            value = DeleteStaff;
            return IsDeleteStaff;
        }

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
        public bool TryPickListAssets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListAssetsParams? value)
        {
            value = ListAssets;
            return IsListAssets;
        }

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
        public bool TryPickCreateAsset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateAssetParams? value)
        {
            value = CreateAsset;
            return IsCreateAsset;
        }

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
        public bool TryPickUpdateAsset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateAssetParams? value)
        {
            value = UpdateAsset;
            return IsUpdateAsset;
        }

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
        public bool TryPickDeleteAsset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteAssetParams? value)
        {
            value = DeleteAsset;
            return IsDeleteAsset;
        }

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
        /// 
        /// </summary>
        public bool TryPickListServices(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListServicesParams? value)
        {
            value = ListServices;
            return IsListServices;
        }

        /// <summary>
        /// Create a new service (classic, rental, or group) in the system.
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
        /// 
        /// </summary>
        public bool TryPickCreateService(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateServiceParams? value)
        {
            value = CreateService;
            return IsCreateService;
        }

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
        /// 
        /// </summary>
        public bool TryPickUpdateService(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateServiceParams? value)
        {
            value = UpdateService;
            return IsUpdateService;
        }

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
        public bool TryPickDeleteService(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteServiceParams? value)
        {
            value = DeleteService;
            return IsDeleteService;
        }

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
        public bool TryPickListProducts(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListProductsParams? value)
        {
            value = ListProducts;
            return IsListProducts;
        }

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
        public bool TryPickCreateProduct(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateProductParams? value)
        {
            value = CreateProduct;
            return IsCreateProduct;
        }

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
        public bool TryPickUpdateProduct(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateProductParams? value)
        {
            value = UpdateProduct;
            return IsUpdateProduct;
        }

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
        public bool TryPickDeleteProduct(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteProductParams? value)
        {
            value = DeleteProduct;
            return IsDeleteProduct;
        }

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
        public bool TryPickCheckServiceAvailability(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CheckServiceAvailabilityParams? value)
        {
            value = CheckServiceAvailability;
            return IsCheckServiceAvailability;
        }

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
        public bool TryPickCreateClientAppointment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateClientAppointmentParams? value)
        {
            value = CreateClientAppointment;
            return IsCreateClientAppointment;
        }

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
        public bool TryPickGetClientAppointments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetClientAppointmentsParams? value)
        {
            value = GetClientAppointments;
            return IsGetClientAppointments;
        }

        /// <summary>
        /// Look up an appointment by the booking confirmation number the caller quotes.<br/>
        /// The confirmation number is the 8-character code shown on the booking<br/>
        /// confirmation page (e.g. ``#01ABCDEF``). Callers may read it back with or<br/>
        /// without the leading ``#`` and with varied spacing; the tool normalizes<br/>
        /// the input and does a prefix match on the stored calendar item id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetAppointmentByConfirmationNumberParams? GetAppointmentByConfirmationNumber { get; init; }
#else
        public global::ElevenLabs.GetAppointmentByConfirmationNumberParams? GetAppointmentByConfirmationNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetAppointmentByConfirmationNumber))]
#endif
        public bool IsGetAppointmentByConfirmationNumber => GetAppointmentByConfirmationNumber != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGetAppointmentByConfirmationNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetAppointmentByConfirmationNumberParams? value)
        {
            value = GetAppointmentByConfirmationNumber;
            return IsGetAppointmentByConfirmationNumber;
        }

        /// <summary>
        /// List scheduled group sessions for a group service in a date range.<br/>
        /// Group services are scheduled in advance (e.g. yoga classes, workshops) and<br/>
        /// callers register against an existing session. Use this for group services;<br/>
        /// use ``check_service_availability`` for appointment / rental services.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListGroupSessionsParams? ListGroupSessions { get; init; }
#else
        public global::ElevenLabs.ListGroupSessionsParams? ListGroupSessions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListGroupSessions))]
#endif
        public bool IsListGroupSessions => ListGroupSessions != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListGroupSessions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListGroupSessionsParams? value)
        {
            value = ListGroupSessions;
            return IsListGroupSessions;
        }

        /// <summary>
        /// Schedule a single instance of a group service.<br/>
        /// The session's duration is derived from the parent service so the assistant<br/>
        /// only has to pin start time, the (optional) instructor / room, and the<br/>
        /// location. Participants register separately via<br/>
        /// ``register_for_group_session``.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ScheduleGroupSessionParams? ScheduleGroupSession { get; init; }
#else
        public global::ElevenLabs.ScheduleGroupSessionParams? ScheduleGroupSession { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScheduleGroupSession))]
#endif
        public bool IsScheduleGroupSession => ScheduleGroupSession != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScheduleGroupSession(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ScheduleGroupSessionParams? value)
        {
            value = ScheduleGroupSession;
            return IsScheduleGroupSession;
        }

        /// <summary>
        /// Register a client for a scheduled group session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.RegisterForGroupSessionParams? RegisterForGroupSession { get; init; }
#else
        public global::ElevenLabs.RegisterForGroupSessionParams? RegisterForGroupSession { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RegisterForGroupSession))]
#endif
        public bool IsRegisterForGroupSession => RegisterForGroupSession != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRegisterForGroupSession(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.RegisterForGroupSessionParams? value)
        {
            value = RegisterForGroupSession;
            return IsRegisterForGroupSession;
        }

        /// <summary>
        /// Cancel a single client's registration for a group session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CancelGroupSessionRegistrationParams? CancelGroupSessionRegistration { get; init; }
#else
        public global::ElevenLabs.CancelGroupSessionRegistrationParams? CancelGroupSessionRegistration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CancelGroupSessionRegistration))]
#endif
        public bool IsCancelGroupSessionRegistration => CancelGroupSessionRegistration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCancelGroupSessionRegistration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CancelGroupSessionRegistrationParams? value)
        {
            value = CancelGroupSessionRegistration;
            return IsCancelGroupSessionRegistration;
        }

        /// <summary>
        /// Change the seat count of an existing group session registration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateGroupSessionSeatsParams? UpdateGroupSessionSeats { get; init; }
#else
        public global::ElevenLabs.UpdateGroupSessionSeatsParams? UpdateGroupSessionSeats { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateGroupSessionSeats))]
#endif
        public bool IsUpdateGroupSessionSeats => UpdateGroupSessionSeats != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUpdateGroupSessionSeats(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateGroupSessionSeatsParams? value)
        {
            value = UpdateGroupSessionSeats;
            return IsUpdateGroupSessionSeats;
        }

        /// <summary>
        /// Cancel an entire group session and notify every registered participant.<br/>
        /// Destructive -- prefer ``cancel_group_session_registration`` for cancelling<br/>
        /// a single attendee.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CancelGroupSessionForAllParams? CancelGroupSessionForAll { get; init; }
#else
        public global::ElevenLabs.CancelGroupSessionForAllParams? CancelGroupSessionForAll { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CancelGroupSessionForAll))]
#endif
        public bool IsCancelGroupSessionForAll => CancelGroupSessionForAll != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCancelGroupSessionForAll(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CancelGroupSessionForAllParams? value)
        {
            value = CancelGroupSessionForAll;
            return IsCancelGroupSessionForAll;
        }

        /// <summary>
        /// Permanently remove a previously-cancelled group session.<br/>
        /// Group analogue of ``delete_calendar_event``: cancel<br/>
        /// (``cancel_group_session_for_all``) is the soft, history-preserving step;<br/>
        /// this tool is the irreversible follow-up that drops the row from Mongo<br/>
        /// and the staff Google Calendar entirely. The backend rejects the call<br/>
        /// (422) if the session hasn't been cancelled yet, so the only safe path<br/>
        /// is cancel-then-delete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteGroupSessionParams? DeleteGroupSession { get; init; }
#else
        public global::ElevenLabs.DeleteGroupSessionParams? DeleteGroupSession { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteGroupSession))]
#endif
        public bool IsDeleteGroupSession => DeleteGroupSession != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeleteGroupSession(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteGroupSessionParams? value)
        {
            value = DeleteGroupSession;
            return IsDeleteGroupSession;
        }

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
        public bool TryPickListCalendarEvents(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListCalendarEventsParams? value)
        {
            value = ListCalendarEvents;
            return IsListCalendarEvents;
        }

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
        public bool TryPickUpdateCalendarEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateCalendarEventParams? value)
        {
            value = UpdateCalendarEvent;
            return IsUpdateCalendarEvent;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CancelCalendarEventParams? CancelCalendarEvent { get; init; }
#else
        public global::ElevenLabs.CancelCalendarEventParams? CancelCalendarEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CancelCalendarEvent))]
#endif
        public bool IsCancelCalendarEvent => CancelCalendarEvent != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCancelCalendarEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CancelCalendarEventParams? value)
        {
            value = CancelCalendarEvent;
            return IsCancelCalendarEvent;
        }

        /// <summary>
        /// Permanently remove a previously-cancelled calendar event.<br/>
        /// This delete tool is the irreversible follow-up to cancel_calendar_event.<br/>
        /// The backend rejects the call (422) if the event hasn't been<br/>
        /// cancelled yet, so the only safe path is cancel-then-delete.
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
        public bool TryPickDeleteCalendarEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteCalendarEventParams? value)
        {
            value = DeleteCalendarEvent;
            return IsDeleteCalendarEvent;
        }

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
        public bool TryPickListAgentRules(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListAgentRulesParams? value)
        {
            value = ListAgentRules;
            return IsListAgentRules;
        }

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
        public bool TryPickCreateAgentRule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateAgentRuleParams? value)
        {
            value = CreateAgentRule;
            return IsCreateAgentRule;
        }

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
        public bool TryPickUpdateAgentRule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateAgentRuleParams? value)
        {
            value = UpdateAgentRule;
            return IsUpdateAgentRule;
        }

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
        public bool TryPickDeleteAgentRule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteAgentRuleParams? value)
        {
            value = DeleteAgentRule;
            return IsDeleteAgentRule;
        }

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
        public bool TryPickListHolidays(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListHolidaysParams? value)
        {
            value = ListHolidays;
            return IsListHolidays;
        }

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
        public bool TryPickCreateHoliday(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateHolidayParams? value)
        {
            value = CreateHoliday;
            return IsCreateHoliday;
        }

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
        public bool TryPickUpdateHoliday(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateHolidayParams? value)
        {
            value = UpdateHoliday;
            return IsUpdateHoliday;
        }

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
        public bool TryPickDeleteHoliday(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteHolidayParams? value)
        {
            value = DeleteHoliday;
            return IsDeleteHoliday;
        }

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
        public bool TryPickGetSchedule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetScheduleParams? value)
        {
            value = GetSchedule;
            return IsGetSchedule;
        }

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
        public bool TryPickUpdateBusinessInfo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateBusinessInfoParams? value)
        {
            value = UpdateBusinessInfo;
            return IsUpdateBusinessInfo;
        }

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
        /// 
        /// </summary>
        public bool TryPickUpdateCustomerFacingConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateCustomerFacingConfigParams? value)
        {
            value = UpdateCustomerFacingConfig;
            return IsUpdateCustomerFacingConfig;
        }

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
        public bool TryPickGetAnalyticsSummary(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetAnalyticsSummaryParams? value)
        {
            value = GetAnalyticsSummary;
            return IsGetAnalyticsSummary;
        }

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
        public bool TryPickGetBookingPageSettings(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetBookingPageSettingsParams? value)
        {
            value = GetBookingPageSettings;
            return IsGetBookingPageSettings;
        }

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
        public bool TryPickUpdateBookingPageSettings(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateBookingPageSettingsParams? value)
        {
            value = UpdateBookingPageSettings;
            return IsUpdateBookingPageSettings;
        }

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
        public bool TryPickGetBookingSlugStatus(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetBookingSlugStatusParams? value)
        {
            value = GetBookingSlugStatus;
            return IsGetBookingSlugStatus;
        }

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
        public bool TryPickSetBookingSlug(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SetBookingSlugParams? value)
        {
            value = SetBookingSlug;
            return IsSetBookingSlug;
        }

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
        public bool TryPickListClientInteractions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListClientInteractionsParams? value)
        {
            value = ListClientInteractions;
            return IsListClientInteractions;
        }

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
        public bool TryPickCreateClientInteraction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateClientInteractionParams? value)
        {
            value = CreateClientInteraction;
            return IsCreateClientInteraction;
        }

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
        public bool TryPickDeleteClientInteraction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteClientInteractionParams? value)
        {
            value = DeleteClientInteraction;
            return IsDeleteClientInteraction;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ListLocationsParams? ListLocations { get; init; }
#else
        public global::ElevenLabs.ListLocationsParams? ListLocations { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListLocations))]
#endif
        public bool IsListLocations => ListLocations != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListLocations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ListLocationsParams? value)
        {
            value = ListLocations;
            return IsListLocations;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateLocationParams? CreateLocation { get; init; }
#else
        public global::ElevenLabs.CreateLocationParams? CreateLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateLocation))]
#endif
        public bool IsCreateLocation => CreateLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.CreateLocationParams? value)
        {
            value = CreateLocation;
            return IsCreateLocation;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UpdateLocationParams? UpdateLocation { get; init; }
#else
        public global::ElevenLabs.UpdateLocationParams? UpdateLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateLocation))]
#endif
        public bool IsUpdateLocation => UpdateLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUpdateLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UpdateLocationParams? value)
        {
            value = UpdateLocation;
            return IsUpdateLocation;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DeleteLocationParams? DeleteLocation { get; init; }
#else
        public global::ElevenLabs.DeleteLocationParams? DeleteLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteLocation))]
#endif
        public bool IsDeleteLocation => DeleteLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDeleteLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DeleteLocationParams? value)
        {
            value = DeleteLocation;
            return IsDeleteLocation;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.LeaveMessageParams? LeaveMessage { get; init; }
#else
        public global::ElevenLabs.LeaveMessageParams? LeaveMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LeaveMessage))]
#endif
        public bool IsLeaveMessage => LeaveMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLeaveMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.LeaveMessageParams? value)
        {
            value = LeaveMessage;
            return IsLeaveMessage;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ReportKnowledgeGapParams? ReportKnowledgeGap { get; init; }
#else
        public global::ElevenLabs.ReportKnowledgeGapParams? ReportKnowledgeGap { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReportKnowledgeGap))]
#endif
        public bool IsReportKnowledgeGap => ReportKnowledgeGap != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReportKnowledgeGap(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ReportKnowledgeGapParams? value)
        {
            value = ReportKnowledgeGap;
            return IsReportKnowledgeGap;
        }
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
        public static Params FromSearchClients(global::ElevenLabs.SearchClientsParams? value) => new Params(value);

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
        public static Params FromListClients(global::ElevenLabs.ListClientsParams? value) => new Params(value);

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
        public static Params FromGetClientByPhone(global::ElevenLabs.GetClientByPhoneParams? value) => new Params(value);

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
        public static Params FromCreateClient(global::ElevenLabs.CreateClientParams? value) => new Params(value);

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
        public static Params FromUpdateClient(global::ElevenLabs.UpdateClientParams? value) => new Params(value);

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
        public static Params FromDeleteClient(global::ElevenLabs.DeleteClientParams? value) => new Params(value);

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
        public static Params FromListStaff(global::ElevenLabs.ListStaffParams? value) => new Params(value);

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
        public static Params FromCreateStaff(global::ElevenLabs.CreateStaffParams? value) => new Params(value);

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
        public static Params FromUpdateStaff(global::ElevenLabs.UpdateStaffParams? value) => new Params(value);

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
        public static Params FromDeleteStaff(global::ElevenLabs.DeleteStaffParams? value) => new Params(value);

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
        public static Params FromListAssets(global::ElevenLabs.ListAssetsParams? value) => new Params(value);

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
        public static Params FromCreateAsset(global::ElevenLabs.CreateAssetParams? value) => new Params(value);

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
        public static Params FromUpdateAsset(global::ElevenLabs.UpdateAssetParams? value) => new Params(value);

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
        public static Params FromDeleteAsset(global::ElevenLabs.DeleteAssetParams? value) => new Params(value);

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
        public static Params FromListServices(global::ElevenLabs.ListServicesParams? value) => new Params(value);

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
        public static Params FromCreateService(global::ElevenLabs.CreateServiceParams? value) => new Params(value);

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
        public static Params FromUpdateService(global::ElevenLabs.UpdateServiceParams? value) => new Params(value);

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
        public static Params FromDeleteService(global::ElevenLabs.DeleteServiceParams? value) => new Params(value);

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
        public static Params FromListProducts(global::ElevenLabs.ListProductsParams? value) => new Params(value);

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
        public static Params FromCreateProduct(global::ElevenLabs.CreateProductParams? value) => new Params(value);

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
        public static Params FromUpdateProduct(global::ElevenLabs.UpdateProductParams? value) => new Params(value);

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
        public static Params FromDeleteProduct(global::ElevenLabs.DeleteProductParams? value) => new Params(value);

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
        public static Params FromCheckServiceAvailability(global::ElevenLabs.CheckServiceAvailabilityParams? value) => new Params(value);

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
        public static Params FromCreateClientAppointment(global::ElevenLabs.CreateClientAppointmentParams? value) => new Params(value);

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
        public static Params FromGetClientAppointments(global::ElevenLabs.GetClientAppointmentsParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.GetAppointmentByConfirmationNumberParams value) => new Params((global::ElevenLabs.GetAppointmentByConfirmationNumberParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetAppointmentByConfirmationNumberParams?(Params @this) => @this.GetAppointmentByConfirmationNumber;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.GetAppointmentByConfirmationNumberParams? value)
        {
            GetAppointmentByConfirmationNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromGetAppointmentByConfirmationNumber(global::ElevenLabs.GetAppointmentByConfirmationNumberParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListGroupSessionsParams value) => new Params((global::ElevenLabs.ListGroupSessionsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListGroupSessionsParams?(Params @this) => @this.ListGroupSessions;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListGroupSessionsParams? value)
        {
            ListGroupSessions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromListGroupSessions(global::ElevenLabs.ListGroupSessionsParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ScheduleGroupSessionParams value) => new Params((global::ElevenLabs.ScheduleGroupSessionParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ScheduleGroupSessionParams?(Params @this) => @this.ScheduleGroupSession;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ScheduleGroupSessionParams? value)
        {
            ScheduleGroupSession = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromScheduleGroupSession(global::ElevenLabs.ScheduleGroupSessionParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.RegisterForGroupSessionParams value) => new Params((global::ElevenLabs.RegisterForGroupSessionParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.RegisterForGroupSessionParams?(Params @this) => @this.RegisterForGroupSession;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.RegisterForGroupSessionParams? value)
        {
            RegisterForGroupSession = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromRegisterForGroupSession(global::ElevenLabs.RegisterForGroupSessionParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CancelGroupSessionRegistrationParams value) => new Params((global::ElevenLabs.CancelGroupSessionRegistrationParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CancelGroupSessionRegistrationParams?(Params @this) => @this.CancelGroupSessionRegistration;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CancelGroupSessionRegistrationParams? value)
        {
            CancelGroupSessionRegistration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromCancelGroupSessionRegistration(global::ElevenLabs.CancelGroupSessionRegistrationParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateGroupSessionSeatsParams value) => new Params((global::ElevenLabs.UpdateGroupSessionSeatsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateGroupSessionSeatsParams?(Params @this) => @this.UpdateGroupSessionSeats;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateGroupSessionSeatsParams? value)
        {
            UpdateGroupSessionSeats = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromUpdateGroupSessionSeats(global::ElevenLabs.UpdateGroupSessionSeatsParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CancelGroupSessionForAllParams value) => new Params((global::ElevenLabs.CancelGroupSessionForAllParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CancelGroupSessionForAllParams?(Params @this) => @this.CancelGroupSessionForAll;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CancelGroupSessionForAllParams? value)
        {
            CancelGroupSessionForAll = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromCancelGroupSessionForAll(global::ElevenLabs.CancelGroupSessionForAllParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteGroupSessionParams value) => new Params((global::ElevenLabs.DeleteGroupSessionParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteGroupSessionParams?(Params @this) => @this.DeleteGroupSession;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteGroupSessionParams? value)
        {
            DeleteGroupSession = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromDeleteGroupSession(global::ElevenLabs.DeleteGroupSessionParams? value) => new Params(value);

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
        public static Params FromListCalendarEvents(global::ElevenLabs.ListCalendarEventsParams? value) => new Params(value);

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
        public static Params FromUpdateCalendarEvent(global::ElevenLabs.UpdateCalendarEventParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CancelCalendarEventParams value) => new Params((global::ElevenLabs.CancelCalendarEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CancelCalendarEventParams?(Params @this) => @this.CancelCalendarEvent;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CancelCalendarEventParams? value)
        {
            CancelCalendarEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromCancelCalendarEvent(global::ElevenLabs.CancelCalendarEventParams? value) => new Params(value);

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
        public static Params FromDeleteCalendarEvent(global::ElevenLabs.DeleteCalendarEventParams? value) => new Params(value);

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
        public static Params FromListAgentRules(global::ElevenLabs.ListAgentRulesParams? value) => new Params(value);

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
        public static Params FromCreateAgentRule(global::ElevenLabs.CreateAgentRuleParams? value) => new Params(value);

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
        public static Params FromUpdateAgentRule(global::ElevenLabs.UpdateAgentRuleParams? value) => new Params(value);

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
        public static Params FromDeleteAgentRule(global::ElevenLabs.DeleteAgentRuleParams? value) => new Params(value);

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
        public static Params FromListHolidays(global::ElevenLabs.ListHolidaysParams? value) => new Params(value);

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
        public static Params FromCreateHoliday(global::ElevenLabs.CreateHolidayParams? value) => new Params(value);

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
        public static Params FromUpdateHoliday(global::ElevenLabs.UpdateHolidayParams? value) => new Params(value);

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
        public static Params FromDeleteHoliday(global::ElevenLabs.DeleteHolidayParams? value) => new Params(value);

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
        public static Params FromGetSchedule(global::ElevenLabs.GetScheduleParams? value) => new Params(value);

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
        public static Params FromUpdateBusinessInfo(global::ElevenLabs.UpdateBusinessInfoParams? value) => new Params(value);

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
        public static Params FromUpdateCustomerFacingConfig(global::ElevenLabs.UpdateCustomerFacingConfigParams? value) => new Params(value);

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
        public static Params FromGetAnalyticsSummary(global::ElevenLabs.GetAnalyticsSummaryParams? value) => new Params(value);

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
        public static Params FromGetBookingPageSettings(global::ElevenLabs.GetBookingPageSettingsParams? value) => new Params(value);

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
        public static Params FromUpdateBookingPageSettings(global::ElevenLabs.UpdateBookingPageSettingsParams? value) => new Params(value);

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
        public static Params FromGetBookingSlugStatus(global::ElevenLabs.GetBookingSlugStatusParams? value) => new Params(value);

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
        public static Params FromSetBookingSlug(global::ElevenLabs.SetBookingSlugParams? value) => new Params(value);

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
        public static Params FromListClientInteractions(global::ElevenLabs.ListClientInteractionsParams? value) => new Params(value);

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
        public static Params FromCreateClientInteraction(global::ElevenLabs.CreateClientInteractionParams? value) => new Params(value);

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
        public static Params FromDeleteClientInteraction(global::ElevenLabs.DeleteClientInteractionParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ListLocationsParams value) => new Params((global::ElevenLabs.ListLocationsParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ListLocationsParams?(Params @this) => @this.ListLocations;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ListLocationsParams? value)
        {
            ListLocations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromListLocations(global::ElevenLabs.ListLocationsParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.CreateLocationParams value) => new Params((global::ElevenLabs.CreateLocationParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateLocationParams?(Params @this) => @this.CreateLocation;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.CreateLocationParams? value)
        {
            CreateLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromCreateLocation(global::ElevenLabs.CreateLocationParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.UpdateLocationParams value) => new Params((global::ElevenLabs.UpdateLocationParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.UpdateLocationParams?(Params @this) => @this.UpdateLocation;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.UpdateLocationParams? value)
        {
            UpdateLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromUpdateLocation(global::ElevenLabs.UpdateLocationParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.DeleteLocationParams value) => new Params((global::ElevenLabs.DeleteLocationParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DeleteLocationParams?(Params @this) => @this.DeleteLocation;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.DeleteLocationParams? value)
        {
            DeleteLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromDeleteLocation(global::ElevenLabs.DeleteLocationParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.LeaveMessageParams value) => new Params((global::ElevenLabs.LeaveMessageParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.LeaveMessageParams?(Params @this) => @this.LeaveMessage;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.LeaveMessageParams? value)
        {
            LeaveMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromLeaveMessage(global::ElevenLabs.LeaveMessageParams? value) => new Params(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Params(global::ElevenLabs.ReportKnowledgeGapParams value) => new Params((global::ElevenLabs.ReportKnowledgeGapParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ReportKnowledgeGapParams?(Params @this) => @this.ReportKnowledgeGap;

        /// <summary>
        /// 
        /// </summary>
        public Params(global::ElevenLabs.ReportKnowledgeGapParams? value)
        {
            ReportKnowledgeGap = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Params FromReportKnowledgeGap(global::ElevenLabs.ReportKnowledgeGapParams? value) => new Params(value);

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
            global::ElevenLabs.GetAppointmentByConfirmationNumberParams? getAppointmentByConfirmationNumber,
            global::ElevenLabs.ListGroupSessionsParams? listGroupSessions,
            global::ElevenLabs.ScheduleGroupSessionParams? scheduleGroupSession,
            global::ElevenLabs.RegisterForGroupSessionParams? registerForGroupSession,
            global::ElevenLabs.CancelGroupSessionRegistrationParams? cancelGroupSessionRegistration,
            global::ElevenLabs.UpdateGroupSessionSeatsParams? updateGroupSessionSeats,
            global::ElevenLabs.CancelGroupSessionForAllParams? cancelGroupSessionForAll,
            global::ElevenLabs.DeleteGroupSessionParams? deleteGroupSession,
            global::ElevenLabs.ListCalendarEventsParams? listCalendarEvents,
            global::ElevenLabs.UpdateCalendarEventParams? updateCalendarEvent,
            global::ElevenLabs.CancelCalendarEventParams? cancelCalendarEvent,
            global::ElevenLabs.DeleteCalendarEventParams? deleteCalendarEvent,
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
            global::ElevenLabs.DeleteClientInteractionParams? deleteClientInteraction,
            global::ElevenLabs.ListLocationsParams? listLocations,
            global::ElevenLabs.CreateLocationParams? createLocation,
            global::ElevenLabs.UpdateLocationParams? updateLocation,
            global::ElevenLabs.DeleteLocationParams? deleteLocation,
            global::ElevenLabs.LeaveMessageParams? leaveMessage,
            global::ElevenLabs.ReportKnowledgeGapParams? reportKnowledgeGap
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
            GetAppointmentByConfirmationNumber = getAppointmentByConfirmationNumber;
            ListGroupSessions = listGroupSessions;
            ScheduleGroupSession = scheduleGroupSession;
            RegisterForGroupSession = registerForGroupSession;
            CancelGroupSessionRegistration = cancelGroupSessionRegistration;
            UpdateGroupSessionSeats = updateGroupSessionSeats;
            CancelGroupSessionForAll = cancelGroupSessionForAll;
            DeleteGroupSession = deleteGroupSession;
            ListCalendarEvents = listCalendarEvents;
            UpdateCalendarEvent = updateCalendarEvent;
            CancelCalendarEvent = cancelCalendarEvent;
            DeleteCalendarEvent = deleteCalendarEvent;
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
            ListLocations = listLocations;
            CreateLocation = createLocation;
            UpdateLocation = updateLocation;
            DeleteLocation = deleteLocation;
            LeaveMessage = leaveMessage;
            ReportKnowledgeGap = reportKnowledgeGap;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReportKnowledgeGap as object ??
            LeaveMessage as object ??
            DeleteLocation as object ??
            UpdateLocation as object ??
            CreateLocation as object ??
            ListLocations as object ??
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
            DeleteCalendarEvent as object ??
            CancelCalendarEvent as object ??
            UpdateCalendarEvent as object ??
            ListCalendarEvents as object ??
            DeleteGroupSession as object ??
            CancelGroupSessionForAll as object ??
            UpdateGroupSessionSeats as object ??
            CancelGroupSessionRegistration as object ??
            RegisterForGroupSession as object ??
            ScheduleGroupSession as object ??
            ListGroupSessions as object ??
            GetAppointmentByConfirmationNumber as object ??
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
            GetAppointmentByConfirmationNumber?.ToString() ??
            ListGroupSessions?.ToString() ??
            ScheduleGroupSession?.ToString() ??
            RegisterForGroupSession?.ToString() ??
            CancelGroupSessionRegistration?.ToString() ??
            UpdateGroupSessionSeats?.ToString() ??
            CancelGroupSessionForAll?.ToString() ??
            DeleteGroupSession?.ToString() ??
            ListCalendarEvents?.ToString() ??
            UpdateCalendarEvent?.ToString() ??
            CancelCalendarEvent?.ToString() ??
            DeleteCalendarEvent?.ToString() ??
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
            DeleteClientInteraction?.ToString() ??
            ListLocations?.ToString() ??
            CreateLocation?.ToString() ??
            UpdateLocation?.ToString() ??
            DeleteLocation?.ToString() ??
            LeaveMessage?.ToString() ??
            ReportKnowledgeGap?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && IsDeleteLocation && !IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && IsLeaveMessage && !IsReportKnowledgeGap || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsGetAppointmentByConfirmationNumber && !IsListGroupSessions && !IsScheduleGroupSession && !IsRegisterForGroupSession && !IsCancelGroupSessionRegistration && !IsUpdateGroupSessionSeats && !IsCancelGroupSessionForAll && !IsDeleteGroupSession && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsCancelCalendarEvent && !IsDeleteCalendarEvent && !IsListAgentRules && !IsCreateAgentRule && !IsUpdateAgentRule && !IsDeleteAgentRule && !IsListHolidays && !IsCreateHoliday && !IsUpdateHoliday && !IsDeleteHoliday && !IsGetSchedule && !IsUpdateBusinessInfo && !IsUpdateCustomerFacingConfig && !IsGetAnalyticsSummary && !IsGetBookingPageSettings && !IsUpdateBookingPageSettings && !IsGetBookingSlugStatus && !IsSetBookingSlug && !IsListClientInteractions && !IsCreateClientInteraction && !IsDeleteClientInteraction && !IsListLocations && !IsCreateLocation && !IsUpdateLocation && !IsDeleteLocation && !IsLeaveMessage && IsReportKnowledgeGap;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.SearchClientsParams, TResult>? searchClients = null,
            global::System.Func<global::ElevenLabs.ListClientsParams, TResult>? listClients = null,
            global::System.Func<global::ElevenLabs.GetClientByPhoneParams, TResult>? getClientByPhone = null,
            global::System.Func<global::ElevenLabs.CreateClientParams, TResult>? createClient = null,
            global::System.Func<global::ElevenLabs.UpdateClientParams, TResult>? updateClient = null,
            global::System.Func<global::ElevenLabs.DeleteClientParams, TResult>? deleteClient = null,
            global::System.Func<global::ElevenLabs.ListStaffParams, TResult>? listStaff = null,
            global::System.Func<global::ElevenLabs.CreateStaffParams, TResult>? createStaff = null,
            global::System.Func<global::ElevenLabs.UpdateStaffParams, TResult>? updateStaff = null,
            global::System.Func<global::ElevenLabs.DeleteStaffParams, TResult>? deleteStaff = null,
            global::System.Func<global::ElevenLabs.ListAssetsParams, TResult>? listAssets = null,
            global::System.Func<global::ElevenLabs.CreateAssetParams, TResult>? createAsset = null,
            global::System.Func<global::ElevenLabs.UpdateAssetParams, TResult>? updateAsset = null,
            global::System.Func<global::ElevenLabs.DeleteAssetParams, TResult>? deleteAsset = null,
            global::System.Func<global::ElevenLabs.ListServicesParams, TResult>? listServices = null,
            global::System.Func<global::ElevenLabs.CreateServiceParams, TResult>? createService = null,
            global::System.Func<global::ElevenLabs.UpdateServiceParams, TResult>? updateService = null,
            global::System.Func<global::ElevenLabs.DeleteServiceParams, TResult>? deleteService = null,
            global::System.Func<global::ElevenLabs.ListProductsParams, TResult>? listProducts = null,
            global::System.Func<global::ElevenLabs.CreateProductParams, TResult>? createProduct = null,
            global::System.Func<global::ElevenLabs.UpdateProductParams, TResult>? updateProduct = null,
            global::System.Func<global::ElevenLabs.DeleteProductParams, TResult>? deleteProduct = null,
            global::System.Func<global::ElevenLabs.CheckServiceAvailabilityParams, TResult>? checkServiceAvailability = null,
            global::System.Func<global::ElevenLabs.CreateClientAppointmentParams, TResult>? createClientAppointment = null,
            global::System.Func<global::ElevenLabs.GetClientAppointmentsParams, TResult>? getClientAppointments = null,
            global::System.Func<global::ElevenLabs.GetAppointmentByConfirmationNumberParams, TResult>? getAppointmentByConfirmationNumber = null,
            global::System.Func<global::ElevenLabs.ListGroupSessionsParams, TResult>? listGroupSessions = null,
            global::System.Func<global::ElevenLabs.ScheduleGroupSessionParams, TResult>? scheduleGroupSession = null,
            global::System.Func<global::ElevenLabs.RegisterForGroupSessionParams, TResult>? registerForGroupSession = null,
            global::System.Func<global::ElevenLabs.CancelGroupSessionRegistrationParams, TResult>? cancelGroupSessionRegistration = null,
            global::System.Func<global::ElevenLabs.UpdateGroupSessionSeatsParams, TResult>? updateGroupSessionSeats = null,
            global::System.Func<global::ElevenLabs.CancelGroupSessionForAllParams, TResult>? cancelGroupSessionForAll = null,
            global::System.Func<global::ElevenLabs.DeleteGroupSessionParams, TResult>? deleteGroupSession = null,
            global::System.Func<global::ElevenLabs.ListCalendarEventsParams, TResult>? listCalendarEvents = null,
            global::System.Func<global::ElevenLabs.UpdateCalendarEventParams, TResult>? updateCalendarEvent = null,
            global::System.Func<global::ElevenLabs.CancelCalendarEventParams, TResult>? cancelCalendarEvent = null,
            global::System.Func<global::ElevenLabs.DeleteCalendarEventParams, TResult>? deleteCalendarEvent = null,
            global::System.Func<global::ElevenLabs.ListAgentRulesParams, TResult>? listAgentRules = null,
            global::System.Func<global::ElevenLabs.CreateAgentRuleParams, TResult>? createAgentRule = null,
            global::System.Func<global::ElevenLabs.UpdateAgentRuleParams, TResult>? updateAgentRule = null,
            global::System.Func<global::ElevenLabs.DeleteAgentRuleParams, TResult>? deleteAgentRule = null,
            global::System.Func<global::ElevenLabs.ListHolidaysParams, TResult>? listHolidays = null,
            global::System.Func<global::ElevenLabs.CreateHolidayParams, TResult>? createHoliday = null,
            global::System.Func<global::ElevenLabs.UpdateHolidayParams, TResult>? updateHoliday = null,
            global::System.Func<global::ElevenLabs.DeleteHolidayParams, TResult>? deleteHoliday = null,
            global::System.Func<global::ElevenLabs.GetScheduleParams, TResult>? getSchedule = null,
            global::System.Func<global::ElevenLabs.UpdateBusinessInfoParams, TResult>? updateBusinessInfo = null,
            global::System.Func<global::ElevenLabs.UpdateCustomerFacingConfigParams, TResult>? updateCustomerFacingConfig = null,
            global::System.Func<global::ElevenLabs.GetAnalyticsSummaryParams, TResult>? getAnalyticsSummary = null,
            global::System.Func<global::ElevenLabs.GetBookingPageSettingsParams, TResult>? getBookingPageSettings = null,
            global::System.Func<global::ElevenLabs.UpdateBookingPageSettingsParams, TResult>? updateBookingPageSettings = null,
            global::System.Func<global::ElevenLabs.GetBookingSlugStatusParams, TResult>? getBookingSlugStatus = null,
            global::System.Func<global::ElevenLabs.SetBookingSlugParams, TResult>? setBookingSlug = null,
            global::System.Func<global::ElevenLabs.ListClientInteractionsParams, TResult>? listClientInteractions = null,
            global::System.Func<global::ElevenLabs.CreateClientInteractionParams, TResult>? createClientInteraction = null,
            global::System.Func<global::ElevenLabs.DeleteClientInteractionParams, TResult>? deleteClientInteraction = null,
            global::System.Func<global::ElevenLabs.ListLocationsParams, TResult>? listLocations = null,
            global::System.Func<global::ElevenLabs.CreateLocationParams, TResult>? createLocation = null,
            global::System.Func<global::ElevenLabs.UpdateLocationParams, TResult>? updateLocation = null,
            global::System.Func<global::ElevenLabs.DeleteLocationParams, TResult>? deleteLocation = null,
            global::System.Func<global::ElevenLabs.LeaveMessageParams, TResult>? leaveMessage = null,
            global::System.Func<global::ElevenLabs.ReportKnowledgeGapParams, TResult>? reportKnowledgeGap = null,
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
            else if (IsGetAppointmentByConfirmationNumber && getAppointmentByConfirmationNumber != null)
            {
                return getAppointmentByConfirmationNumber(GetAppointmentByConfirmationNumber!);
            }
            else if (IsListGroupSessions && listGroupSessions != null)
            {
                return listGroupSessions(ListGroupSessions!);
            }
            else if (IsScheduleGroupSession && scheduleGroupSession != null)
            {
                return scheduleGroupSession(ScheduleGroupSession!);
            }
            else if (IsRegisterForGroupSession && registerForGroupSession != null)
            {
                return registerForGroupSession(RegisterForGroupSession!);
            }
            else if (IsCancelGroupSessionRegistration && cancelGroupSessionRegistration != null)
            {
                return cancelGroupSessionRegistration(CancelGroupSessionRegistration!);
            }
            else if (IsUpdateGroupSessionSeats && updateGroupSessionSeats != null)
            {
                return updateGroupSessionSeats(UpdateGroupSessionSeats!);
            }
            else if (IsCancelGroupSessionForAll && cancelGroupSessionForAll != null)
            {
                return cancelGroupSessionForAll(CancelGroupSessionForAll!);
            }
            else if (IsDeleteGroupSession && deleteGroupSession != null)
            {
                return deleteGroupSession(DeleteGroupSession!);
            }
            else if (IsListCalendarEvents && listCalendarEvents != null)
            {
                return listCalendarEvents(ListCalendarEvents!);
            }
            else if (IsUpdateCalendarEvent && updateCalendarEvent != null)
            {
                return updateCalendarEvent(UpdateCalendarEvent!);
            }
            else if (IsCancelCalendarEvent && cancelCalendarEvent != null)
            {
                return cancelCalendarEvent(CancelCalendarEvent!);
            }
            else if (IsDeleteCalendarEvent && deleteCalendarEvent != null)
            {
                return deleteCalendarEvent(DeleteCalendarEvent!);
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
            else if (IsListLocations && listLocations != null)
            {
                return listLocations(ListLocations!);
            }
            else if (IsCreateLocation && createLocation != null)
            {
                return createLocation(CreateLocation!);
            }
            else if (IsUpdateLocation && updateLocation != null)
            {
                return updateLocation(UpdateLocation!);
            }
            else if (IsDeleteLocation && deleteLocation != null)
            {
                return deleteLocation(DeleteLocation!);
            }
            else if (IsLeaveMessage && leaveMessage != null)
            {
                return leaveMessage(LeaveMessage!);
            }
            else if (IsReportKnowledgeGap && reportKnowledgeGap != null)
            {
                return reportKnowledgeGap(ReportKnowledgeGap!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.SearchClientsParams>? searchClients = null,

            global::System.Action<global::ElevenLabs.ListClientsParams>? listClients = null,

            global::System.Action<global::ElevenLabs.GetClientByPhoneParams>? getClientByPhone = null,

            global::System.Action<global::ElevenLabs.CreateClientParams>? createClient = null,

            global::System.Action<global::ElevenLabs.UpdateClientParams>? updateClient = null,

            global::System.Action<global::ElevenLabs.DeleteClientParams>? deleteClient = null,

            global::System.Action<global::ElevenLabs.ListStaffParams>? listStaff = null,

            global::System.Action<global::ElevenLabs.CreateStaffParams>? createStaff = null,

            global::System.Action<global::ElevenLabs.UpdateStaffParams>? updateStaff = null,

            global::System.Action<global::ElevenLabs.DeleteStaffParams>? deleteStaff = null,

            global::System.Action<global::ElevenLabs.ListAssetsParams>? listAssets = null,

            global::System.Action<global::ElevenLabs.CreateAssetParams>? createAsset = null,

            global::System.Action<global::ElevenLabs.UpdateAssetParams>? updateAsset = null,

            global::System.Action<global::ElevenLabs.DeleteAssetParams>? deleteAsset = null,

            global::System.Action<global::ElevenLabs.ListServicesParams>? listServices = null,

            global::System.Action<global::ElevenLabs.CreateServiceParams>? createService = null,

            global::System.Action<global::ElevenLabs.UpdateServiceParams>? updateService = null,

            global::System.Action<global::ElevenLabs.DeleteServiceParams>? deleteService = null,

            global::System.Action<global::ElevenLabs.ListProductsParams>? listProducts = null,

            global::System.Action<global::ElevenLabs.CreateProductParams>? createProduct = null,

            global::System.Action<global::ElevenLabs.UpdateProductParams>? updateProduct = null,

            global::System.Action<global::ElevenLabs.DeleteProductParams>? deleteProduct = null,

            global::System.Action<global::ElevenLabs.CheckServiceAvailabilityParams>? checkServiceAvailability = null,

            global::System.Action<global::ElevenLabs.CreateClientAppointmentParams>? createClientAppointment = null,

            global::System.Action<global::ElevenLabs.GetClientAppointmentsParams>? getClientAppointments = null,

            global::System.Action<global::ElevenLabs.GetAppointmentByConfirmationNumberParams>? getAppointmentByConfirmationNumber = null,

            global::System.Action<global::ElevenLabs.ListGroupSessionsParams>? listGroupSessions = null,

            global::System.Action<global::ElevenLabs.ScheduleGroupSessionParams>? scheduleGroupSession = null,

            global::System.Action<global::ElevenLabs.RegisterForGroupSessionParams>? registerForGroupSession = null,

            global::System.Action<global::ElevenLabs.CancelGroupSessionRegistrationParams>? cancelGroupSessionRegistration = null,

            global::System.Action<global::ElevenLabs.UpdateGroupSessionSeatsParams>? updateGroupSessionSeats = null,

            global::System.Action<global::ElevenLabs.CancelGroupSessionForAllParams>? cancelGroupSessionForAll = null,

            global::System.Action<global::ElevenLabs.DeleteGroupSessionParams>? deleteGroupSession = null,

            global::System.Action<global::ElevenLabs.ListCalendarEventsParams>? listCalendarEvents = null,

            global::System.Action<global::ElevenLabs.UpdateCalendarEventParams>? updateCalendarEvent = null,

            global::System.Action<global::ElevenLabs.CancelCalendarEventParams>? cancelCalendarEvent = null,

            global::System.Action<global::ElevenLabs.DeleteCalendarEventParams>? deleteCalendarEvent = null,

            global::System.Action<global::ElevenLabs.ListAgentRulesParams>? listAgentRules = null,

            global::System.Action<global::ElevenLabs.CreateAgentRuleParams>? createAgentRule = null,

            global::System.Action<global::ElevenLabs.UpdateAgentRuleParams>? updateAgentRule = null,

            global::System.Action<global::ElevenLabs.DeleteAgentRuleParams>? deleteAgentRule = null,

            global::System.Action<global::ElevenLabs.ListHolidaysParams>? listHolidays = null,

            global::System.Action<global::ElevenLabs.CreateHolidayParams>? createHoliday = null,

            global::System.Action<global::ElevenLabs.UpdateHolidayParams>? updateHoliday = null,

            global::System.Action<global::ElevenLabs.DeleteHolidayParams>? deleteHoliday = null,

            global::System.Action<global::ElevenLabs.GetScheduleParams>? getSchedule = null,

            global::System.Action<global::ElevenLabs.UpdateBusinessInfoParams>? updateBusinessInfo = null,

            global::System.Action<global::ElevenLabs.UpdateCustomerFacingConfigParams>? updateCustomerFacingConfig = null,

            global::System.Action<global::ElevenLabs.GetAnalyticsSummaryParams>? getAnalyticsSummary = null,

            global::System.Action<global::ElevenLabs.GetBookingPageSettingsParams>? getBookingPageSettings = null,

            global::System.Action<global::ElevenLabs.UpdateBookingPageSettingsParams>? updateBookingPageSettings = null,

            global::System.Action<global::ElevenLabs.GetBookingSlugStatusParams>? getBookingSlugStatus = null,

            global::System.Action<global::ElevenLabs.SetBookingSlugParams>? setBookingSlug = null,

            global::System.Action<global::ElevenLabs.ListClientInteractionsParams>? listClientInteractions = null,

            global::System.Action<global::ElevenLabs.CreateClientInteractionParams>? createClientInteraction = null,

            global::System.Action<global::ElevenLabs.DeleteClientInteractionParams>? deleteClientInteraction = null,

            global::System.Action<global::ElevenLabs.ListLocationsParams>? listLocations = null,

            global::System.Action<global::ElevenLabs.CreateLocationParams>? createLocation = null,

            global::System.Action<global::ElevenLabs.UpdateLocationParams>? updateLocation = null,

            global::System.Action<global::ElevenLabs.DeleteLocationParams>? deleteLocation = null,

            global::System.Action<global::ElevenLabs.LeaveMessageParams>? leaveMessage = null,

            global::System.Action<global::ElevenLabs.ReportKnowledgeGapParams>? reportKnowledgeGap = null,
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
            else if (IsGetAppointmentByConfirmationNumber)
            {
                getAppointmentByConfirmationNumber?.Invoke(GetAppointmentByConfirmationNumber!);
            }
            else if (IsListGroupSessions)
            {
                listGroupSessions?.Invoke(ListGroupSessions!);
            }
            else if (IsScheduleGroupSession)
            {
                scheduleGroupSession?.Invoke(ScheduleGroupSession!);
            }
            else if (IsRegisterForGroupSession)
            {
                registerForGroupSession?.Invoke(RegisterForGroupSession!);
            }
            else if (IsCancelGroupSessionRegistration)
            {
                cancelGroupSessionRegistration?.Invoke(CancelGroupSessionRegistration!);
            }
            else if (IsUpdateGroupSessionSeats)
            {
                updateGroupSessionSeats?.Invoke(UpdateGroupSessionSeats!);
            }
            else if (IsCancelGroupSessionForAll)
            {
                cancelGroupSessionForAll?.Invoke(CancelGroupSessionForAll!);
            }
            else if (IsDeleteGroupSession)
            {
                deleteGroupSession?.Invoke(DeleteGroupSession!);
            }
            else if (IsListCalendarEvents)
            {
                listCalendarEvents?.Invoke(ListCalendarEvents!);
            }
            else if (IsUpdateCalendarEvent)
            {
                updateCalendarEvent?.Invoke(UpdateCalendarEvent!);
            }
            else if (IsCancelCalendarEvent)
            {
                cancelCalendarEvent?.Invoke(CancelCalendarEvent!);
            }
            else if (IsDeleteCalendarEvent)
            {
                deleteCalendarEvent?.Invoke(DeleteCalendarEvent!);
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
            else if (IsListLocations)
            {
                listLocations?.Invoke(ListLocations!);
            }
            else if (IsCreateLocation)
            {
                createLocation?.Invoke(CreateLocation!);
            }
            else if (IsUpdateLocation)
            {
                updateLocation?.Invoke(UpdateLocation!);
            }
            else if (IsDeleteLocation)
            {
                deleteLocation?.Invoke(DeleteLocation!);
            }
            else if (IsLeaveMessage)
            {
                leaveMessage?.Invoke(LeaveMessage!);
            }
            else if (IsReportKnowledgeGap)
            {
                reportKnowledgeGap?.Invoke(ReportKnowledgeGap!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.SearchClientsParams>? searchClients = null,
            global::System.Action<global::ElevenLabs.ListClientsParams>? listClients = null,
            global::System.Action<global::ElevenLabs.GetClientByPhoneParams>? getClientByPhone = null,
            global::System.Action<global::ElevenLabs.CreateClientParams>? createClient = null,
            global::System.Action<global::ElevenLabs.UpdateClientParams>? updateClient = null,
            global::System.Action<global::ElevenLabs.DeleteClientParams>? deleteClient = null,
            global::System.Action<global::ElevenLabs.ListStaffParams>? listStaff = null,
            global::System.Action<global::ElevenLabs.CreateStaffParams>? createStaff = null,
            global::System.Action<global::ElevenLabs.UpdateStaffParams>? updateStaff = null,
            global::System.Action<global::ElevenLabs.DeleteStaffParams>? deleteStaff = null,
            global::System.Action<global::ElevenLabs.ListAssetsParams>? listAssets = null,
            global::System.Action<global::ElevenLabs.CreateAssetParams>? createAsset = null,
            global::System.Action<global::ElevenLabs.UpdateAssetParams>? updateAsset = null,
            global::System.Action<global::ElevenLabs.DeleteAssetParams>? deleteAsset = null,
            global::System.Action<global::ElevenLabs.ListServicesParams>? listServices = null,
            global::System.Action<global::ElevenLabs.CreateServiceParams>? createService = null,
            global::System.Action<global::ElevenLabs.UpdateServiceParams>? updateService = null,
            global::System.Action<global::ElevenLabs.DeleteServiceParams>? deleteService = null,
            global::System.Action<global::ElevenLabs.ListProductsParams>? listProducts = null,
            global::System.Action<global::ElevenLabs.CreateProductParams>? createProduct = null,
            global::System.Action<global::ElevenLabs.UpdateProductParams>? updateProduct = null,
            global::System.Action<global::ElevenLabs.DeleteProductParams>? deleteProduct = null,
            global::System.Action<global::ElevenLabs.CheckServiceAvailabilityParams>? checkServiceAvailability = null,
            global::System.Action<global::ElevenLabs.CreateClientAppointmentParams>? createClientAppointment = null,
            global::System.Action<global::ElevenLabs.GetClientAppointmentsParams>? getClientAppointments = null,
            global::System.Action<global::ElevenLabs.GetAppointmentByConfirmationNumberParams>? getAppointmentByConfirmationNumber = null,
            global::System.Action<global::ElevenLabs.ListGroupSessionsParams>? listGroupSessions = null,
            global::System.Action<global::ElevenLabs.ScheduleGroupSessionParams>? scheduleGroupSession = null,
            global::System.Action<global::ElevenLabs.RegisterForGroupSessionParams>? registerForGroupSession = null,
            global::System.Action<global::ElevenLabs.CancelGroupSessionRegistrationParams>? cancelGroupSessionRegistration = null,
            global::System.Action<global::ElevenLabs.UpdateGroupSessionSeatsParams>? updateGroupSessionSeats = null,
            global::System.Action<global::ElevenLabs.CancelGroupSessionForAllParams>? cancelGroupSessionForAll = null,
            global::System.Action<global::ElevenLabs.DeleteGroupSessionParams>? deleteGroupSession = null,
            global::System.Action<global::ElevenLabs.ListCalendarEventsParams>? listCalendarEvents = null,
            global::System.Action<global::ElevenLabs.UpdateCalendarEventParams>? updateCalendarEvent = null,
            global::System.Action<global::ElevenLabs.CancelCalendarEventParams>? cancelCalendarEvent = null,
            global::System.Action<global::ElevenLabs.DeleteCalendarEventParams>? deleteCalendarEvent = null,
            global::System.Action<global::ElevenLabs.ListAgentRulesParams>? listAgentRules = null,
            global::System.Action<global::ElevenLabs.CreateAgentRuleParams>? createAgentRule = null,
            global::System.Action<global::ElevenLabs.UpdateAgentRuleParams>? updateAgentRule = null,
            global::System.Action<global::ElevenLabs.DeleteAgentRuleParams>? deleteAgentRule = null,
            global::System.Action<global::ElevenLabs.ListHolidaysParams>? listHolidays = null,
            global::System.Action<global::ElevenLabs.CreateHolidayParams>? createHoliday = null,
            global::System.Action<global::ElevenLabs.UpdateHolidayParams>? updateHoliday = null,
            global::System.Action<global::ElevenLabs.DeleteHolidayParams>? deleteHoliday = null,
            global::System.Action<global::ElevenLabs.GetScheduleParams>? getSchedule = null,
            global::System.Action<global::ElevenLabs.UpdateBusinessInfoParams>? updateBusinessInfo = null,
            global::System.Action<global::ElevenLabs.UpdateCustomerFacingConfigParams>? updateCustomerFacingConfig = null,
            global::System.Action<global::ElevenLabs.GetAnalyticsSummaryParams>? getAnalyticsSummary = null,
            global::System.Action<global::ElevenLabs.GetBookingPageSettingsParams>? getBookingPageSettings = null,
            global::System.Action<global::ElevenLabs.UpdateBookingPageSettingsParams>? updateBookingPageSettings = null,
            global::System.Action<global::ElevenLabs.GetBookingSlugStatusParams>? getBookingSlugStatus = null,
            global::System.Action<global::ElevenLabs.SetBookingSlugParams>? setBookingSlug = null,
            global::System.Action<global::ElevenLabs.ListClientInteractionsParams>? listClientInteractions = null,
            global::System.Action<global::ElevenLabs.CreateClientInteractionParams>? createClientInteraction = null,
            global::System.Action<global::ElevenLabs.DeleteClientInteractionParams>? deleteClientInteraction = null,
            global::System.Action<global::ElevenLabs.ListLocationsParams>? listLocations = null,
            global::System.Action<global::ElevenLabs.CreateLocationParams>? createLocation = null,
            global::System.Action<global::ElevenLabs.UpdateLocationParams>? updateLocation = null,
            global::System.Action<global::ElevenLabs.DeleteLocationParams>? deleteLocation = null,
            global::System.Action<global::ElevenLabs.LeaveMessageParams>? leaveMessage = null,
            global::System.Action<global::ElevenLabs.ReportKnowledgeGapParams>? reportKnowledgeGap = null,
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
            else if (IsGetAppointmentByConfirmationNumber)
            {
                getAppointmentByConfirmationNumber?.Invoke(GetAppointmentByConfirmationNumber!);
            }
            else if (IsListGroupSessions)
            {
                listGroupSessions?.Invoke(ListGroupSessions!);
            }
            else if (IsScheduleGroupSession)
            {
                scheduleGroupSession?.Invoke(ScheduleGroupSession!);
            }
            else if (IsRegisterForGroupSession)
            {
                registerForGroupSession?.Invoke(RegisterForGroupSession!);
            }
            else if (IsCancelGroupSessionRegistration)
            {
                cancelGroupSessionRegistration?.Invoke(CancelGroupSessionRegistration!);
            }
            else if (IsUpdateGroupSessionSeats)
            {
                updateGroupSessionSeats?.Invoke(UpdateGroupSessionSeats!);
            }
            else if (IsCancelGroupSessionForAll)
            {
                cancelGroupSessionForAll?.Invoke(CancelGroupSessionForAll!);
            }
            else if (IsDeleteGroupSession)
            {
                deleteGroupSession?.Invoke(DeleteGroupSession!);
            }
            else if (IsListCalendarEvents)
            {
                listCalendarEvents?.Invoke(ListCalendarEvents!);
            }
            else if (IsUpdateCalendarEvent)
            {
                updateCalendarEvent?.Invoke(UpdateCalendarEvent!);
            }
            else if (IsCancelCalendarEvent)
            {
                cancelCalendarEvent?.Invoke(CancelCalendarEvent!);
            }
            else if (IsDeleteCalendarEvent)
            {
                deleteCalendarEvent?.Invoke(DeleteCalendarEvent!);
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
            else if (IsListLocations)
            {
                listLocations?.Invoke(ListLocations!);
            }
            else if (IsCreateLocation)
            {
                createLocation?.Invoke(CreateLocation!);
            }
            else if (IsUpdateLocation)
            {
                updateLocation?.Invoke(UpdateLocation!);
            }
            else if (IsDeleteLocation)
            {
                deleteLocation?.Invoke(DeleteLocation!);
            }
            else if (IsLeaveMessage)
            {
                leaveMessage?.Invoke(LeaveMessage!);
            }
            else if (IsReportKnowledgeGap)
            {
                reportKnowledgeGap?.Invoke(ReportKnowledgeGap!);
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
                GetAppointmentByConfirmationNumber,
                typeof(global::ElevenLabs.GetAppointmentByConfirmationNumberParams),
                ListGroupSessions,
                typeof(global::ElevenLabs.ListGroupSessionsParams),
                ScheduleGroupSession,
                typeof(global::ElevenLabs.ScheduleGroupSessionParams),
                RegisterForGroupSession,
                typeof(global::ElevenLabs.RegisterForGroupSessionParams),
                CancelGroupSessionRegistration,
                typeof(global::ElevenLabs.CancelGroupSessionRegistrationParams),
                UpdateGroupSessionSeats,
                typeof(global::ElevenLabs.UpdateGroupSessionSeatsParams),
                CancelGroupSessionForAll,
                typeof(global::ElevenLabs.CancelGroupSessionForAllParams),
                DeleteGroupSession,
                typeof(global::ElevenLabs.DeleteGroupSessionParams),
                ListCalendarEvents,
                typeof(global::ElevenLabs.ListCalendarEventsParams),
                UpdateCalendarEvent,
                typeof(global::ElevenLabs.UpdateCalendarEventParams),
                CancelCalendarEvent,
                typeof(global::ElevenLabs.CancelCalendarEventParams),
                DeleteCalendarEvent,
                typeof(global::ElevenLabs.DeleteCalendarEventParams),
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
                ListLocations,
                typeof(global::ElevenLabs.ListLocationsParams),
                CreateLocation,
                typeof(global::ElevenLabs.CreateLocationParams),
                UpdateLocation,
                typeof(global::ElevenLabs.UpdateLocationParams),
                DeleteLocation,
                typeof(global::ElevenLabs.DeleteLocationParams),
                LeaveMessage,
                typeof(global::ElevenLabs.LeaveMessageParams),
                ReportKnowledgeGap,
                typeof(global::ElevenLabs.ReportKnowledgeGapParams),
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetAppointmentByConfirmationNumberParams?>.Default.Equals(GetAppointmentByConfirmationNumber, other.GetAppointmentByConfirmationNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListGroupSessionsParams?>.Default.Equals(ListGroupSessions, other.ListGroupSessions) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ScheduleGroupSessionParams?>.Default.Equals(ScheduleGroupSession, other.ScheduleGroupSession) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.RegisterForGroupSessionParams?>.Default.Equals(RegisterForGroupSession, other.RegisterForGroupSession) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CancelGroupSessionRegistrationParams?>.Default.Equals(CancelGroupSessionRegistration, other.CancelGroupSessionRegistration) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateGroupSessionSeatsParams?>.Default.Equals(UpdateGroupSessionSeats, other.UpdateGroupSessionSeats) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CancelGroupSessionForAllParams?>.Default.Equals(CancelGroupSessionForAll, other.CancelGroupSessionForAll) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteGroupSessionParams?>.Default.Equals(DeleteGroupSession, other.DeleteGroupSession) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListCalendarEventsParams?>.Default.Equals(ListCalendarEvents, other.ListCalendarEvents) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateCalendarEventParams?>.Default.Equals(UpdateCalendarEvent, other.UpdateCalendarEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CancelCalendarEventParams?>.Default.Equals(CancelCalendarEvent, other.CancelCalendarEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteCalendarEventParams?>.Default.Equals(DeleteCalendarEvent, other.DeleteCalendarEvent) &&
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteClientInteractionParams?>.Default.Equals(DeleteClientInteraction, other.DeleteClientInteraction) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ListLocationsParams?>.Default.Equals(ListLocations, other.ListLocations) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateLocationParams?>.Default.Equals(CreateLocation, other.CreateLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UpdateLocationParams?>.Default.Equals(UpdateLocation, other.UpdateLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DeleteLocationParams?>.Default.Equals(DeleteLocation, other.DeleteLocation) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.LeaveMessageParams?>.Default.Equals(LeaveMessage, other.LeaveMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ReportKnowledgeGapParams?>.Default.Equals(ReportKnowledgeGap, other.ReportKnowledgeGap) 
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
