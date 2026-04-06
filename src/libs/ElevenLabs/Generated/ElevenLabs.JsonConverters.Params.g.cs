#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Params>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Params Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SMBToolConfigParamsDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.SearchClientsParams? searchClients = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients)
            {
                searchClients = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SearchClientsParams>(ref reader, options);
            }
            global::ElevenLabs.ListClientsParams? listClients = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListClients)
            {
                listClients = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListClientsParams>(ref reader, options);
            }
            global::ElevenLabs.GetClientByPhoneParams? getClientByPhone = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone)
            {
                getClientByPhone = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetClientByPhoneParams>(ref reader, options);
            }
            global::ElevenLabs.CreateClientParams? createClient = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient)
            {
                createClient = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateClientParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateClientParams? updateClient = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient)
            {
                updateClient = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateClientParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteClientParams? deleteClient = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient)
            {
                deleteClient = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteClientParams>(ref reader, options);
            }
            global::ElevenLabs.ListStaffParams? listStaff = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff)
            {
                listStaff = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListStaffParams>(ref reader, options);
            }
            global::ElevenLabs.CreateStaffParams? createStaff = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff)
            {
                createStaff = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateStaffParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateStaffParams? updateStaff = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateStaff)
            {
                updateStaff = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateStaffParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteStaffParams? deleteStaff = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff)
            {
                deleteStaff = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteStaffParams>(ref reader, options);
            }
            global::ElevenLabs.ListAssetsParams? listAssets = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets)
            {
                listAssets = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListAssetsParams>(ref reader, options);
            }
            global::ElevenLabs.CreateAssetParams? createAsset = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset)
            {
                createAsset = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateAssetParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateAssetParams? updateAsset = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset)
            {
                updateAsset = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateAssetParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteAssetParams? deleteAsset = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset)
            {
                deleteAsset = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteAssetParams>(ref reader, options);
            }
            global::ElevenLabs.ListServicesParams? listServices = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListServices)
            {
                listServices = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListServicesParams>(ref reader, options);
            }
            global::ElevenLabs.CreateServiceParams? createService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateService)
            {
                createService = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateServiceParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateServiceParams? updateService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateService)
            {
                updateService = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateServiceParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteServiceParams? deleteService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService)
            {
                deleteService = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteServiceParams>(ref reader, options);
            }
            global::ElevenLabs.ListProductsParams? listProducts = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts)
            {
                listProducts = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListProductsParams>(ref reader, options);
            }
            global::ElevenLabs.CreateProductParams? createProduct = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct)
            {
                createProduct = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateProductParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateProductParams? updateProduct = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct)
            {
                updateProduct = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateProductParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteProductParams? deleteProduct = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct)
            {
                deleteProduct = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteProductParams>(ref reader, options);
            }
            global::ElevenLabs.CheckServiceAvailabilityParams? checkServiceAvailability = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability)
            {
                checkServiceAvailability = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CheckServiceAvailabilityParams>(ref reader, options);
            }
            global::ElevenLabs.CreateClientAppointmentParams? createClientAppointment = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment)
            {
                createClientAppointment = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateClientAppointmentParams>(ref reader, options);
            }
            global::ElevenLabs.GetClientAppointmentsParams? getClientAppointments = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments)
            {
                getClientAppointments = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetClientAppointmentsParams>(ref reader, options);
            }
            global::ElevenLabs.ListCalendarEventsParams? listCalendarEvents = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents)
            {
                listCalendarEvents = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListCalendarEventsParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateCalendarEventParams? updateCalendarEvent = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent)
            {
                updateCalendarEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateCalendarEventParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteCalendarEventParams? deleteCalendarEvent = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent)
            {
                deleteCalendarEvent = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteCalendarEventParams>(ref reader, options);
            }
            global::ElevenLabs.ListRentalServicesParams? listRentalServices = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListRentalServices)
            {
                listRentalServices = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListRentalServicesParams>(ref reader, options);
            }
            global::ElevenLabs.CreateRentalServiceParams? createRentalService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalService)
            {
                createRentalService = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateRentalServiceParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateRentalServiceParams? updateRentalService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateRentalService)
            {
                updateRentalService = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateRentalServiceParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteRentalServiceParams? deleteRentalService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteRentalService)
            {
                deleteRentalService = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteRentalServiceParams>(ref reader, options);
            }
            global::ElevenLabs.CheckRentalAvailabilityParams? checkRentalAvailability = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CheckRentalAvailability)
            {
                checkRentalAvailability = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CheckRentalAvailabilityParams>(ref reader, options);
            }
            global::ElevenLabs.CreateRentalBookingParams? createRentalBooking = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalBooking)
            {
                createRentalBooking = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateRentalBookingParams>(ref reader, options);
            }
            global::ElevenLabs.ListAgentRulesParams? listAgentRules = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListAgentRules)
            {
                listAgentRules = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListAgentRulesParams>(ref reader, options);
            }
            global::ElevenLabs.CreateAgentRuleParams? createAgentRule = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateAgentRule)
            {
                createAgentRule = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateAgentRuleParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateAgentRuleParams? updateAgentRule = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAgentRule)
            {
                updateAgentRule = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateAgentRuleParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteAgentRuleParams? deleteAgentRule = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAgentRule)
            {
                deleteAgentRule = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteAgentRuleParams>(ref reader, options);
            }
            global::ElevenLabs.ListHolidaysParams? listHolidays = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListHolidays)
            {
                listHolidays = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListHolidaysParams>(ref reader, options);
            }
            global::ElevenLabs.CreateHolidayParams? createHoliday = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateHoliday)
            {
                createHoliday = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateHolidayParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateHolidayParams? updateHoliday = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateHoliday)
            {
                updateHoliday = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateHolidayParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteHolidayParams? deleteHoliday = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteHoliday)
            {
                deleteHoliday = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteHolidayParams>(ref reader, options);
            }
            global::ElevenLabs.GetScheduleParams? getSchedule = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetSchedule)
            {
                getSchedule = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetScheduleParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateBusinessInfoParams? updateBusinessInfo = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBusinessInfo)
            {
                updateBusinessInfo = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateBusinessInfoParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateCustomerFacingConfigParams? updateCustomerFacingConfig = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCustomerFacingConfig)
            {
                updateCustomerFacingConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateCustomerFacingConfigParams>(ref reader, options);
            }
            global::ElevenLabs.GetAnalyticsSummaryParams? getAnalyticsSummary = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetAnalyticsSummary)
            {
                getAnalyticsSummary = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetAnalyticsSummaryParams>(ref reader, options);
            }
            global::ElevenLabs.GetBookingPageSettingsParams? getBookingPageSettings = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingPageSettings)
            {
                getBookingPageSettings = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetBookingPageSettingsParams>(ref reader, options);
            }
            global::ElevenLabs.UpdateBookingPageSettingsParams? updateBookingPageSettings = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBookingPageSettings)
            {
                updateBookingPageSettings = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UpdateBookingPageSettingsParams>(ref reader, options);
            }
            global::ElevenLabs.GetBookingSlugStatusParams? getBookingSlugStatus = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingSlugStatus)
            {
                getBookingSlugStatus = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetBookingSlugStatusParams>(ref reader, options);
            }
            global::ElevenLabs.SetBookingSlugParams? setBookingSlug = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.SetBookingSlug)
            {
                setBookingSlug = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SetBookingSlugParams>(ref reader, options);
            }
            global::ElevenLabs.ListClientInteractionsParams? listClientInteractions = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListClientInteractions)
            {
                listClientInteractions = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListClientInteractionsParams>(ref reader, options);
            }
            global::ElevenLabs.CreateClientInteractionParams? createClientInteraction = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientInteraction)
            {
                createClientInteraction = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CreateClientInteractionParams>(ref reader, options);
            }
            global::ElevenLabs.DeleteClientInteractionParams? deleteClientInteraction = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClientInteraction)
            {
                deleteClientInteraction = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DeleteClientInteractionParams>(ref reader, options);
            }

            var __value = new global::ElevenLabs.Params(
                discriminator?.SmbToolType,
                searchClients,

                listClients,

                getClientByPhone,

                createClient,

                updateClient,

                deleteClient,

                listStaff,

                createStaff,

                updateStaff,

                deleteStaff,

                listAssets,

                createAsset,

                updateAsset,

                deleteAsset,

                listServices,

                createService,

                updateService,

                deleteService,

                listProducts,

                createProduct,

                updateProduct,

                deleteProduct,

                checkServiceAvailability,

                createClientAppointment,

                getClientAppointments,

                listCalendarEvents,

                updateCalendarEvent,

                deleteCalendarEvent,

                listRentalServices,

                createRentalService,

                updateRentalService,

                deleteRentalService,

                checkRentalAvailability,

                createRentalBooking,

                listAgentRules,

                createAgentRule,

                updateAgentRule,

                deleteAgentRule,

                listHolidays,

                createHoliday,

                updateHoliday,

                deleteHoliday,

                getSchedule,

                updateBusinessInfo,

                updateCustomerFacingConfig,

                getAnalyticsSummary,

                getBookingPageSettings,

                updateBookingPageSettings,

                getBookingSlugStatus,

                setBookingSlug,

                listClientInteractions,

                createClientInteraction,

                deleteClientInteraction
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Params value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSearchClients)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchClients, typeof(global::ElevenLabs.SearchClientsParams), options);
            }
            else if (value.IsListClients)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListClients, typeof(global::ElevenLabs.ListClientsParams), options);
            }
            else if (value.IsGetClientByPhone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetClientByPhone, typeof(global::ElevenLabs.GetClientByPhoneParams), options);
            }
            else if (value.IsCreateClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClient, typeof(global::ElevenLabs.CreateClientParams), options);
            }
            else if (value.IsUpdateClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateClient, typeof(global::ElevenLabs.UpdateClientParams), options);
            }
            else if (value.IsDeleteClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteClient, typeof(global::ElevenLabs.DeleteClientParams), options);
            }
            else if (value.IsListStaff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListStaff, typeof(global::ElevenLabs.ListStaffParams), options);
            }
            else if (value.IsCreateStaff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateStaff, typeof(global::ElevenLabs.CreateStaffParams), options);
            }
            else if (value.IsUpdateStaff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateStaff, typeof(global::ElevenLabs.UpdateStaffParams), options);
            }
            else if (value.IsDeleteStaff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteStaff, typeof(global::ElevenLabs.DeleteStaffParams), options);
            }
            else if (value.IsListAssets)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListAssets, typeof(global::ElevenLabs.ListAssetsParams), options);
            }
            else if (value.IsCreateAsset)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateAsset, typeof(global::ElevenLabs.CreateAssetParams), options);
            }
            else if (value.IsUpdateAsset)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateAsset, typeof(global::ElevenLabs.UpdateAssetParams), options);
            }
            else if (value.IsDeleteAsset)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteAsset, typeof(global::ElevenLabs.DeleteAssetParams), options);
            }
            else if (value.IsListServices)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListServices, typeof(global::ElevenLabs.ListServicesParams), options);
            }
            else if (value.IsCreateService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateService, typeof(global::ElevenLabs.CreateServiceParams), options);
            }
            else if (value.IsUpdateService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateService, typeof(global::ElevenLabs.UpdateServiceParams), options);
            }
            else if (value.IsDeleteService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteService, typeof(global::ElevenLabs.DeleteServiceParams), options);
            }
            else if (value.IsListProducts)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListProducts, typeof(global::ElevenLabs.ListProductsParams), options);
            }
            else if (value.IsCreateProduct)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateProduct, typeof(global::ElevenLabs.CreateProductParams), options);
            }
            else if (value.IsUpdateProduct)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateProduct, typeof(global::ElevenLabs.UpdateProductParams), options);
            }
            else if (value.IsDeleteProduct)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteProduct, typeof(global::ElevenLabs.DeleteProductParams), options);
            }
            else if (value.IsCheckServiceAvailability)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckServiceAvailability, typeof(global::ElevenLabs.CheckServiceAvailabilityParams), options);
            }
            else if (value.IsCreateClientAppointment)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClientAppointment, typeof(global::ElevenLabs.CreateClientAppointmentParams), options);
            }
            else if (value.IsGetClientAppointments)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetClientAppointments, typeof(global::ElevenLabs.GetClientAppointmentsParams), options);
            }
            else if (value.IsListCalendarEvents)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListCalendarEvents, typeof(global::ElevenLabs.ListCalendarEventsParams), options);
            }
            else if (value.IsUpdateCalendarEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateCalendarEvent, typeof(global::ElevenLabs.UpdateCalendarEventParams), options);
            }
            else if (value.IsDeleteCalendarEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteCalendarEvent, typeof(global::ElevenLabs.DeleteCalendarEventParams), options);
            }
            else if (value.IsListRentalServices)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListRentalServices, typeof(global::ElevenLabs.ListRentalServicesParams), options);
            }
            else if (value.IsCreateRentalService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateRentalService, typeof(global::ElevenLabs.CreateRentalServiceParams), options);
            }
            else if (value.IsUpdateRentalService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateRentalService, typeof(global::ElevenLabs.UpdateRentalServiceParams), options);
            }
            else if (value.IsDeleteRentalService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteRentalService, typeof(global::ElevenLabs.DeleteRentalServiceParams), options);
            }
            else if (value.IsCheckRentalAvailability)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckRentalAvailability, typeof(global::ElevenLabs.CheckRentalAvailabilityParams), options);
            }
            else if (value.IsCreateRentalBooking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateRentalBooking, typeof(global::ElevenLabs.CreateRentalBookingParams), options);
            }
            else if (value.IsListAgentRules)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListAgentRules, typeof(global::ElevenLabs.ListAgentRulesParams), options);
            }
            else if (value.IsCreateAgentRule)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateAgentRule, typeof(global::ElevenLabs.CreateAgentRuleParams), options);
            }
            else if (value.IsUpdateAgentRule)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateAgentRule, typeof(global::ElevenLabs.UpdateAgentRuleParams), options);
            }
            else if (value.IsDeleteAgentRule)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteAgentRule, typeof(global::ElevenLabs.DeleteAgentRuleParams), options);
            }
            else if (value.IsListHolidays)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListHolidays, typeof(global::ElevenLabs.ListHolidaysParams), options);
            }
            else if (value.IsCreateHoliday)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateHoliday, typeof(global::ElevenLabs.CreateHolidayParams), options);
            }
            else if (value.IsUpdateHoliday)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateHoliday, typeof(global::ElevenLabs.UpdateHolidayParams), options);
            }
            else if (value.IsDeleteHoliday)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteHoliday, typeof(global::ElevenLabs.DeleteHolidayParams), options);
            }
            else if (value.IsGetSchedule)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetSchedule, typeof(global::ElevenLabs.GetScheduleParams), options);
            }
            else if (value.IsUpdateBusinessInfo)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateBusinessInfo, typeof(global::ElevenLabs.UpdateBusinessInfoParams), options);
            }
            else if (value.IsUpdateCustomerFacingConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateCustomerFacingConfig, typeof(global::ElevenLabs.UpdateCustomerFacingConfigParams), options);
            }
            else if (value.IsGetAnalyticsSummary)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetAnalyticsSummary, typeof(global::ElevenLabs.GetAnalyticsSummaryParams), options);
            }
            else if (value.IsGetBookingPageSettings)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetBookingPageSettings, typeof(global::ElevenLabs.GetBookingPageSettingsParams), options);
            }
            else if (value.IsUpdateBookingPageSettings)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateBookingPageSettings, typeof(global::ElevenLabs.UpdateBookingPageSettingsParams), options);
            }
            else if (value.IsGetBookingSlugStatus)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetBookingSlugStatus, typeof(global::ElevenLabs.GetBookingSlugStatusParams), options);
            }
            else if (value.IsSetBookingSlug)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SetBookingSlug, typeof(global::ElevenLabs.SetBookingSlugParams), options);
            }
            else if (value.IsListClientInteractions)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListClientInteractions, typeof(global::ElevenLabs.ListClientInteractionsParams), options);
            }
            else if (value.IsCreateClientInteraction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClientInteraction, typeof(global::ElevenLabs.CreateClientInteractionParams), options);
            }
            else if (value.IsDeleteClientInteraction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteClientInteraction, typeof(global::ElevenLabs.DeleteClientInteractionParams), options);
            }
        }
    }
}