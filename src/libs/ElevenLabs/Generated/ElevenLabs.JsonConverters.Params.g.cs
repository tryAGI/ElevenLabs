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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SMBToolConfigParamsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SMBToolConfigParamsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SMBToolConfigParamsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.SearchClientsParams? searchClients = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SearchClientsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SearchClientsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SearchClientsParams)}");
                searchClients = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListClientsParams? listClients = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListClients)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListClientsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListClientsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListClientsParams)}");
                listClients = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetClientByPhoneParams? getClientByPhone = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetClientByPhoneParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetClientByPhoneParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetClientByPhoneParams)}");
                getClientByPhone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateClientParams? createClient = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateClientParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateClientParams)}");
                createClient = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateClientParams? updateClient = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateClientParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateClientParams)}");
                updateClient = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteClientParams? deleteClient = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteClientParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteClientParams)}");
                deleteClient = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListStaffParams? listStaff = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListStaffParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListStaffParams)}");
                listStaff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateStaffParams? createStaff = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateStaffParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateStaffParams)}");
                createStaff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateStaffParams? updateStaff = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateStaffParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateStaffParams)}");
                updateStaff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteStaffParams? deleteStaff = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteStaffParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteStaffParams)}");
                deleteStaff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListAssetsParams? listAssets = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListAssetsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListAssetsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListAssetsParams)}");
                listAssets = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateAssetParams? createAsset = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateAssetParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateAssetParams)}");
                createAsset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateAssetParams? updateAsset = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateAssetParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateAssetParams)}");
                updateAsset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteAssetParams? deleteAsset = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteAssetParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteAssetParams)}");
                deleteAsset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListServicesParams? listServices = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListServices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListServicesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListServicesParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListServicesParams)}");
                listServices = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateServiceParams? createService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateServiceParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateServiceParams)}");
                createService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateServiceParams? updateService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateServiceParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateServiceParams)}");
                updateService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteServiceParams? deleteService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteServiceParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteServiceParams)}");
                deleteService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListProductsParams? listProducts = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListProductsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListProductsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListProductsParams)}");
                listProducts = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateProductParams? createProduct = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateProductParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateProductParams)}");
                createProduct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateProductParams? updateProduct = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateProductParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateProductParams)}");
                updateProduct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteProductParams? deleteProduct = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteProductParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteProductParams)}");
                deleteProduct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CheckServiceAvailabilityParams? checkServiceAvailability = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CheckServiceAvailabilityParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CheckServiceAvailabilityParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CheckServiceAvailabilityParams)}");
                checkServiceAvailability = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateClientAppointmentParams? createClientAppointment = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateClientAppointmentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateClientAppointmentParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateClientAppointmentParams)}");
                createClientAppointment = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetClientAppointmentsParams? getClientAppointments = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetClientAppointmentsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetClientAppointmentsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetClientAppointmentsParams)}");
                getClientAppointments = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListCalendarEventsParams? listCalendarEvents = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListCalendarEventsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListCalendarEventsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListCalendarEventsParams)}");
                listCalendarEvents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateCalendarEventParams? updateCalendarEvent = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateCalendarEventParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateCalendarEventParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateCalendarEventParams)}");
                updateCalendarEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteCalendarEventParams? deleteCalendarEvent = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteCalendarEventParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteCalendarEventParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteCalendarEventParams)}");
                deleteCalendarEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListRentalServicesParams? listRentalServices = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListRentalServices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListRentalServicesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListRentalServicesParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListRentalServicesParams)}");
                listRentalServices = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateRentalServiceParams? createRentalService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateRentalServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateRentalServiceParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateRentalServiceParams)}");
                createRentalService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateRentalServiceParams? updateRentalService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateRentalService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateRentalServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateRentalServiceParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateRentalServiceParams)}");
                updateRentalService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteRentalServiceParams? deleteRentalService = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteRentalService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteRentalServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteRentalServiceParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteRentalServiceParams)}");
                deleteRentalService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CheckRentalAvailabilityParams? checkRentalAvailability = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CheckRentalAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CheckRentalAvailabilityParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CheckRentalAvailabilityParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CheckRentalAvailabilityParams)}");
                checkRentalAvailability = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateRentalBookingParams? createRentalBooking = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalBooking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateRentalBookingParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateRentalBookingParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateRentalBookingParams)}");
                createRentalBooking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListAgentRulesParams? listAgentRules = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListAgentRules)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListAgentRulesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListAgentRulesParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListAgentRulesParams)}");
                listAgentRules = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateAgentRuleParams? createAgentRule = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateAgentRule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateAgentRuleParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateAgentRuleParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateAgentRuleParams)}");
                createAgentRule = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateAgentRuleParams? updateAgentRule = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAgentRule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateAgentRuleParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateAgentRuleParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateAgentRuleParams)}");
                updateAgentRule = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteAgentRuleParams? deleteAgentRule = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAgentRule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteAgentRuleParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteAgentRuleParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteAgentRuleParams)}");
                deleteAgentRule = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListHolidaysParams? listHolidays = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListHolidays)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListHolidaysParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListHolidaysParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListHolidaysParams)}");
                listHolidays = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateHolidayParams? createHoliday = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateHoliday)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateHolidayParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateHolidayParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateHolidayParams)}");
                createHoliday = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateHolidayParams? updateHoliday = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateHoliday)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateHolidayParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateHolidayParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateHolidayParams)}");
                updateHoliday = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteHolidayParams? deleteHoliday = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteHoliday)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteHolidayParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteHolidayParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteHolidayParams)}");
                deleteHoliday = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetScheduleParams? getSchedule = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetSchedule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetScheduleParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetScheduleParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetScheduleParams)}");
                getSchedule = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateBusinessInfoParams? updateBusinessInfo = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBusinessInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateBusinessInfoParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateBusinessInfoParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateBusinessInfoParams)}");
                updateBusinessInfo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateCustomerFacingConfigParams? updateCustomerFacingConfig = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCustomerFacingConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateCustomerFacingConfigParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateCustomerFacingConfigParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateCustomerFacingConfigParams)}");
                updateCustomerFacingConfig = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetAnalyticsSummaryParams? getAnalyticsSummary = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetAnalyticsSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetAnalyticsSummaryParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetAnalyticsSummaryParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetAnalyticsSummaryParams)}");
                getAnalyticsSummary = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetBookingPageSettingsParams? getBookingPageSettings = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingPageSettings)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetBookingPageSettingsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetBookingPageSettingsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetBookingPageSettingsParams)}");
                getBookingPageSettings = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UpdateBookingPageSettingsParams? updateBookingPageSettings = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBookingPageSettings)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateBookingPageSettingsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateBookingPageSettingsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateBookingPageSettingsParams)}");
                updateBookingPageSettings = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetBookingSlugStatusParams? getBookingSlugStatus = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingSlugStatus)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetBookingSlugStatusParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetBookingSlugStatusParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetBookingSlugStatusParams)}");
                getBookingSlugStatus = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SetBookingSlugParams? setBookingSlug = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.SetBookingSlug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SetBookingSlugParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SetBookingSlugParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SetBookingSlugParams)}");
                setBookingSlug = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ListClientInteractionsParams? listClientInteractions = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.ListClientInteractions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListClientInteractionsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListClientInteractionsParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ListClientInteractionsParams)}");
                listClientInteractions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CreateClientInteractionParams? createClientInteraction = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientInteraction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateClientInteractionParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateClientInteractionParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateClientInteractionParams)}");
                createClientInteraction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DeleteClientInteractionParams? deleteClientInteraction = default;
            if (discriminator?.SmbToolType == global::ElevenLabs.SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClientInteraction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteClientInteractionParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteClientInteractionParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DeleteClientInteractionParams)}");
                deleteClientInteraction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSearchClients)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SearchClientsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SearchClientsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SearchClientsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchClients!, typeInfo);
            }
            else if (value.IsListClients)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListClientsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListClientsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListClientsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListClients!, typeInfo);
            }
            else if (value.IsGetClientByPhone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetClientByPhoneParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetClientByPhoneParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetClientByPhoneParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetClientByPhone!, typeInfo);
            }
            else if (value.IsCreateClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateClientParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateClientParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClient!, typeInfo);
            }
            else if (value.IsUpdateClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateClientParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateClientParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateClient!, typeInfo);
            }
            else if (value.IsDeleteClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteClientParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteClientParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteClientParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteClient!, typeInfo);
            }
            else if (value.IsListStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListStaffParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListStaffParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListStaff!, typeInfo);
            }
            else if (value.IsCreateStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateStaffParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateStaffParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateStaff!, typeInfo);
            }
            else if (value.IsUpdateStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateStaffParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateStaffParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateStaff!, typeInfo);
            }
            else if (value.IsDeleteStaff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteStaffParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteStaffParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteStaffParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteStaff!, typeInfo);
            }
            else if (value.IsListAssets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListAssetsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListAssetsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListAssetsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListAssets!, typeInfo);
            }
            else if (value.IsCreateAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateAssetParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateAssetParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateAsset!, typeInfo);
            }
            else if (value.IsUpdateAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateAssetParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateAssetParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateAsset!, typeInfo);
            }
            else if (value.IsDeleteAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteAssetParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteAssetParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteAssetParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteAsset!, typeInfo);
            }
            else if (value.IsListServices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListServicesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListServicesParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListServicesParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListServices!, typeInfo);
            }
            else if (value.IsCreateService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateServiceParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateServiceParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateService!, typeInfo);
            }
            else if (value.IsUpdateService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateServiceParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateServiceParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateService!, typeInfo);
            }
            else if (value.IsDeleteService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteServiceParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteServiceParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteService!, typeInfo);
            }
            else if (value.IsListProducts)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListProductsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListProductsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListProductsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListProducts!, typeInfo);
            }
            else if (value.IsCreateProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateProductParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateProductParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateProduct!, typeInfo);
            }
            else if (value.IsUpdateProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateProductParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateProductParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateProduct!, typeInfo);
            }
            else if (value.IsDeleteProduct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteProductParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteProductParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteProductParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteProduct!, typeInfo);
            }
            else if (value.IsCheckServiceAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CheckServiceAvailabilityParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CheckServiceAvailabilityParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CheckServiceAvailabilityParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckServiceAvailability!, typeInfo);
            }
            else if (value.IsCreateClientAppointment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateClientAppointmentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateClientAppointmentParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateClientAppointmentParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClientAppointment!, typeInfo);
            }
            else if (value.IsGetClientAppointments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetClientAppointmentsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetClientAppointmentsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetClientAppointmentsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetClientAppointments!, typeInfo);
            }
            else if (value.IsListCalendarEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListCalendarEventsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListCalendarEventsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListCalendarEventsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListCalendarEvents!, typeInfo);
            }
            else if (value.IsUpdateCalendarEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateCalendarEventParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateCalendarEventParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateCalendarEventParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateCalendarEvent!, typeInfo);
            }
            else if (value.IsDeleteCalendarEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteCalendarEventParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteCalendarEventParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteCalendarEventParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteCalendarEvent!, typeInfo);
            }
            else if (value.IsListRentalServices)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListRentalServicesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListRentalServicesParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListRentalServicesParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListRentalServices!, typeInfo);
            }
            else if (value.IsCreateRentalService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateRentalServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateRentalServiceParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateRentalServiceParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateRentalService!, typeInfo);
            }
            else if (value.IsUpdateRentalService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateRentalServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateRentalServiceParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateRentalServiceParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateRentalService!, typeInfo);
            }
            else if (value.IsDeleteRentalService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteRentalServiceParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteRentalServiceParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteRentalServiceParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteRentalService!, typeInfo);
            }
            else if (value.IsCheckRentalAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CheckRentalAvailabilityParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CheckRentalAvailabilityParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CheckRentalAvailabilityParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CheckRentalAvailability!, typeInfo);
            }
            else if (value.IsCreateRentalBooking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateRentalBookingParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateRentalBookingParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateRentalBookingParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateRentalBooking!, typeInfo);
            }
            else if (value.IsListAgentRules)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListAgentRulesParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListAgentRulesParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListAgentRulesParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListAgentRules!, typeInfo);
            }
            else if (value.IsCreateAgentRule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateAgentRuleParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateAgentRuleParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateAgentRuleParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateAgentRule!, typeInfo);
            }
            else if (value.IsUpdateAgentRule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateAgentRuleParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateAgentRuleParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateAgentRuleParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateAgentRule!, typeInfo);
            }
            else if (value.IsDeleteAgentRule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteAgentRuleParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteAgentRuleParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteAgentRuleParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteAgentRule!, typeInfo);
            }
            else if (value.IsListHolidays)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListHolidaysParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListHolidaysParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListHolidaysParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListHolidays!, typeInfo);
            }
            else if (value.IsCreateHoliday)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateHolidayParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateHolidayParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateHolidayParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateHoliday!, typeInfo);
            }
            else if (value.IsUpdateHoliday)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateHolidayParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateHolidayParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateHolidayParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateHoliday!, typeInfo);
            }
            else if (value.IsDeleteHoliday)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteHolidayParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteHolidayParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteHolidayParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteHoliday!, typeInfo);
            }
            else if (value.IsGetSchedule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetScheduleParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetScheduleParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetScheduleParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetSchedule!, typeInfo);
            }
            else if (value.IsUpdateBusinessInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateBusinessInfoParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateBusinessInfoParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateBusinessInfoParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateBusinessInfo!, typeInfo);
            }
            else if (value.IsUpdateCustomerFacingConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateCustomerFacingConfigParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateCustomerFacingConfigParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateCustomerFacingConfigParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateCustomerFacingConfig!, typeInfo);
            }
            else if (value.IsGetAnalyticsSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetAnalyticsSummaryParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetAnalyticsSummaryParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetAnalyticsSummaryParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetAnalyticsSummary!, typeInfo);
            }
            else if (value.IsGetBookingPageSettings)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetBookingPageSettingsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetBookingPageSettingsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetBookingPageSettingsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetBookingPageSettings!, typeInfo);
            }
            else if (value.IsUpdateBookingPageSettings)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateBookingPageSettingsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateBookingPageSettingsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UpdateBookingPageSettingsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateBookingPageSettings!, typeInfo);
            }
            else if (value.IsGetBookingSlugStatus)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetBookingSlugStatusParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetBookingSlugStatusParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetBookingSlugStatusParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GetBookingSlugStatus!, typeInfo);
            }
            else if (value.IsSetBookingSlug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SetBookingSlugParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SetBookingSlugParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SetBookingSlugParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SetBookingSlug!, typeInfo);
            }
            else if (value.IsListClientInteractions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ListClientInteractionsParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ListClientInteractionsParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ListClientInteractionsParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListClientInteractions!, typeInfo);
            }
            else if (value.IsCreateClientInteraction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateClientInteractionParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateClientInteractionParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreateClientInteractionParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateClientInteraction!, typeInfo);
            }
            else if (value.IsDeleteClientInteraction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DeleteClientInteractionParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DeleteClientInteractionParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DeleteClientInteractionParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteClientInteraction!, typeInfo);
            }
        }
    }
}