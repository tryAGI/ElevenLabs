
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SMBToolConfigParamsDiscriminatorSmbToolType
    {
        /// <summary>
        /// 
        /// </summary>
        CheckRentalAvailability,
        /// <summary>
        /// 
        /// </summary>
        CheckServiceAvailability,
        /// <summary>
        /// 
        /// </summary>
        CreateAgentRule,
        /// <summary>
        /// 
        /// </summary>
        CreateAsset,
        /// <summary>
        /// 
        /// </summary>
        CreateClient,
        /// <summary>
        /// 
        /// </summary>
        CreateClientAppointment,
        /// <summary>
        /// 
        /// </summary>
        CreateClientInteraction,
        /// <summary>
        /// 
        /// </summary>
        CreateHoliday,
        /// <summary>
        /// 
        /// </summary>
        CreateProduct,
        /// <summary>
        /// 
        /// </summary>
        CreateRentalBooking,
        /// <summary>
        /// 
        /// </summary>
        CreateRentalService,
        /// <summary>
        /// 
        /// </summary>
        CreateService,
        /// <summary>
        /// 
        /// </summary>
        CreateStaff,
        /// <summary>
        /// 
        /// </summary>
        DeleteAgentRule,
        /// <summary>
        /// 
        /// </summary>
        DeleteAsset,
        /// <summary>
        /// 
        /// </summary>
        DeleteCalendarEvent,
        /// <summary>
        /// 
        /// </summary>
        DeleteClient,
        /// <summary>
        /// 
        /// </summary>
        DeleteClientInteraction,
        /// <summary>
        /// 
        /// </summary>
        DeleteHoliday,
        /// <summary>
        /// 
        /// </summary>
        DeleteProduct,
        /// <summary>
        /// 
        /// </summary>
        DeleteRentalService,
        /// <summary>
        /// 
        /// </summary>
        DeleteService,
        /// <summary>
        /// 
        /// </summary>
        DeleteStaff,
        /// <summary>
        /// 
        /// </summary>
        GetAnalyticsSummary,
        /// <summary>
        /// 
        /// </summary>
        GetBookingPageSettings,
        /// <summary>
        /// 
        /// </summary>
        GetBookingSlugStatus,
        /// <summary>
        /// 
        /// </summary>
        GetClientAppointments,
        /// <summary>
        /// 
        /// </summary>
        GetClientByPhone,
        /// <summary>
        /// 
        /// </summary>
        GetSchedule,
        /// <summary>
        /// 
        /// </summary>
        ListAgentRules,
        /// <summary>
        /// 
        /// </summary>
        ListAssets,
        /// <summary>
        /// 
        /// </summary>
        ListCalendarEvents,
        /// <summary>
        /// 
        /// </summary>
        ListClientInteractions,
        /// <summary>
        /// 
        /// </summary>
        ListClients,
        /// <summary>
        /// 
        /// </summary>
        ListHolidays,
        /// <summary>
        /// 
        /// </summary>
        ListProducts,
        /// <summary>
        /// 
        /// </summary>
        ListRentalServices,
        /// <summary>
        /// 
        /// </summary>
        ListServices,
        /// <summary>
        /// 
        /// </summary>
        ListStaff,
        /// <summary>
        /// 
        /// </summary>
        SearchClients,
        /// <summary>
        /// 
        /// </summary>
        SetBookingSlug,
        /// <summary>
        /// 
        /// </summary>
        UpdateAgentRule,
        /// <summary>
        /// 
        /// </summary>
        UpdateAsset,
        /// <summary>
        /// 
        /// </summary>
        UpdateBookingPageSettings,
        /// <summary>
        /// 
        /// </summary>
        UpdateBusinessInfo,
        /// <summary>
        /// 
        /// </summary>
        UpdateCalendarEvent,
        /// <summary>
        /// 
        /// </summary>
        UpdateClient,
        /// <summary>
        /// 
        /// </summary>
        UpdateCustomerFacingConfig,
        /// <summary>
        /// 
        /// </summary>
        UpdateHoliday,
        /// <summary>
        /// 
        /// </summary>
        UpdateProduct,
        /// <summary>
        /// 
        /// </summary>
        UpdateRentalService,
        /// <summary>
        /// 
        /// </summary>
        UpdateService,
        /// <summary>
        /// 
        /// </summary>
        UpdateStaff,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBToolConfigParamsDiscriminatorSmbToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBToolConfigParamsDiscriminatorSmbToolType value)
        {
            return value switch
            {
                SMBToolConfigParamsDiscriminatorSmbToolType.CheckRentalAvailability => "check_rental_availability",
                SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability => "check_service_availability",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateAgentRule => "create_agent_rule",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset => "create_asset",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient => "create_client",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment => "create_client_appointment",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientInteraction => "create_client_interaction",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateHoliday => "create_holiday",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct => "create_product",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalBooking => "create_rental_booking",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalService => "create_rental_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateService => "create_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff => "create_staff",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAgentRule => "delete_agent_rule",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset => "delete_asset",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent => "delete_calendar_event",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient => "delete_client",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClientInteraction => "delete_client_interaction",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteHoliday => "delete_holiday",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct => "delete_product",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteRentalService => "delete_rental_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService => "delete_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff => "delete_staff",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetAnalyticsSummary => "get_analytics_summary",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingPageSettings => "get_booking_page_settings",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingSlugStatus => "get_booking_slug_status",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments => "get_client_appointments",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone => "get_client_by_phone",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetSchedule => "get_schedule",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListAgentRules => "list_agent_rules",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets => "list_assets",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents => "list_calendar_events",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListClientInteractions => "list_client_interactions",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListClients => "list_clients",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListHolidays => "list_holidays",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts => "list_products",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListRentalServices => "list_rental_services",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListServices => "list_services",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff => "list_staff",
                SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients => "search_clients",
                SMBToolConfigParamsDiscriminatorSmbToolType.SetBookingSlug => "set_booking_slug",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAgentRule => "update_agent_rule",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset => "update_asset",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBookingPageSettings => "update_booking_page_settings",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBusinessInfo => "update_business_info",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent => "update_calendar_event",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient => "update_client",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCustomerFacingConfig => "update_customer_facing_config",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateHoliday => "update_holiday",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct => "update_product",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateRentalService => "update_rental_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateService => "update_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateStaff => "update_staff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBToolConfigParamsDiscriminatorSmbToolType? ToEnum(string value)
        {
            return value switch
            {
                "check_rental_availability" => SMBToolConfigParamsDiscriminatorSmbToolType.CheckRentalAvailability,
                "check_service_availability" => SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability,
                "create_agent_rule" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateAgentRule,
                "create_asset" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset,
                "create_client" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient,
                "create_client_appointment" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment,
                "create_client_interaction" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientInteraction,
                "create_holiday" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateHoliday,
                "create_product" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct,
                "create_rental_booking" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalBooking,
                "create_rental_service" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateRentalService,
                "create_service" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateService,
                "create_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff,
                "delete_agent_rule" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAgentRule,
                "delete_asset" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset,
                "delete_calendar_event" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent,
                "delete_client" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient,
                "delete_client_interaction" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClientInteraction,
                "delete_holiday" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteHoliday,
                "delete_product" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct,
                "delete_rental_service" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteRentalService,
                "delete_service" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService,
                "delete_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff,
                "get_analytics_summary" => SMBToolConfigParamsDiscriminatorSmbToolType.GetAnalyticsSummary,
                "get_booking_page_settings" => SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingPageSettings,
                "get_booking_slug_status" => SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingSlugStatus,
                "get_client_appointments" => SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments,
                "get_client_by_phone" => SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone,
                "get_schedule" => SMBToolConfigParamsDiscriminatorSmbToolType.GetSchedule,
                "list_agent_rules" => SMBToolConfigParamsDiscriminatorSmbToolType.ListAgentRules,
                "list_assets" => SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets,
                "list_calendar_events" => SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents,
                "list_client_interactions" => SMBToolConfigParamsDiscriminatorSmbToolType.ListClientInteractions,
                "list_clients" => SMBToolConfigParamsDiscriminatorSmbToolType.ListClients,
                "list_holidays" => SMBToolConfigParamsDiscriminatorSmbToolType.ListHolidays,
                "list_products" => SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts,
                "list_rental_services" => SMBToolConfigParamsDiscriminatorSmbToolType.ListRentalServices,
                "list_services" => SMBToolConfigParamsDiscriminatorSmbToolType.ListServices,
                "list_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff,
                "search_clients" => SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients,
                "set_booking_slug" => SMBToolConfigParamsDiscriminatorSmbToolType.SetBookingSlug,
                "update_agent_rule" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAgentRule,
                "update_asset" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset,
                "update_booking_page_settings" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBookingPageSettings,
                "update_business_info" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBusinessInfo,
                "update_calendar_event" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent,
                "update_client" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient,
                "update_customer_facing_config" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCustomerFacingConfig,
                "update_holiday" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateHoliday,
                "update_product" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct,
                "update_rental_service" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateRentalService,
                "update_service" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateService,
                "update_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateStaff,
                _ => null,
            };
        }
    }
}