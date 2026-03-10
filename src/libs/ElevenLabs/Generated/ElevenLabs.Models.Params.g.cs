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
            global::ElevenLabs.CheckRentalAvailabilityParams? checkRentalAvailability,
            global::ElevenLabs.CreateRentalBookingParams? createRentalBooking
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
            CheckRentalAvailability = checkRentalAvailability;
            CreateRentalBooking = createRentalBooking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateRentalBooking as object ??
            CheckRentalAvailability as object ??
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
            CheckRentalAvailability?.ToString() ??
            CreateRentalBooking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && IsListRentalServices && !IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && IsCheckRentalAvailability && !IsCreateRentalBooking || !IsSearchClients && !IsListClients && !IsGetClientByPhone && !IsCreateClient && !IsUpdateClient && !IsDeleteClient && !IsListStaff && !IsCreateStaff && !IsUpdateStaff && !IsDeleteStaff && !IsListAssets && !IsCreateAsset && !IsUpdateAsset && !IsDeleteAsset && !IsListServices && !IsCreateService && !IsUpdateService && !IsDeleteService && !IsListProducts && !IsCreateProduct && !IsUpdateProduct && !IsDeleteProduct && !IsCheckServiceAvailability && !IsCreateClientAppointment && !IsGetClientAppointments && !IsListCalendarEvents && !IsUpdateCalendarEvent && !IsDeleteCalendarEvent && !IsListRentalServices && !IsCheckRentalAvailability && IsCreateRentalBooking;
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
            global::System.Func<global::ElevenLabs.CheckRentalAvailabilityParams?, TResult>? checkRentalAvailability = null,
            global::System.Func<global::ElevenLabs.CreateRentalBookingParams?, TResult>? createRentalBooking = null,
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
            else if (IsCheckRentalAvailability && checkRentalAvailability != null)
            {
                return checkRentalAvailability(CheckRentalAvailability!);
            }
            else if (IsCreateRentalBooking && createRentalBooking != null)
            {
                return createRentalBooking(CreateRentalBooking!);
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
            global::System.Action<global::ElevenLabs.CheckRentalAvailabilityParams?>? checkRentalAvailability = null,
            global::System.Action<global::ElevenLabs.CreateRentalBookingParams?>? createRentalBooking = null,
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
            else if (IsCheckRentalAvailability)
            {
                checkRentalAvailability?.Invoke(CheckRentalAvailability!);
            }
            else if (IsCreateRentalBooking)
            {
                createRentalBooking?.Invoke(CreateRentalBooking!);
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
                CheckRentalAvailability,
                typeof(global::ElevenLabs.CheckRentalAvailabilityParams),
                CreateRentalBooking,
                typeof(global::ElevenLabs.CreateRentalBookingParams),
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CheckRentalAvailabilityParams?>.Default.Equals(CheckRentalAvailability, other.CheckRentalAvailability) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateRentalBookingParams?>.Default.Equals(CreateRentalBooking, other.CreateRentalBooking) 
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
