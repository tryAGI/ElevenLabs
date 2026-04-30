
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
        CancelCalendarEvent,
        /// <summary>
        /// 
        /// </summary>
        CancelGroupSessionForAll,
        /// <summary>
        /// 
        /// </summary>
        CancelGroupSessionRegistration,
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
        CreateLocation,
        /// <summary>
        /// 
        /// </summary>
        CreateProduct,
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
        DeleteGroupSession,
        /// <summary>
        /// 
        /// </summary>
        DeleteHoliday,
        /// <summary>
        /// 
        /// </summary>
        DeleteLocation,
        /// <summary>
        /// 
        /// </summary>
        DeleteProduct,
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
        GetAppointmentByConfirmationNumber,
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
        LeaveMessage,
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
        ListGroupSessions,
        /// <summary>
        /// 
        /// </summary>
        ListHolidays,
        /// <summary>
        /// 
        /// </summary>
        ListLocations,
        /// <summary>
        /// 
        /// </summary>
        ListProducts,
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
        RegisterForGroupSession,
        /// <summary>
        /// 
        /// </summary>
        ScheduleGroupSession,
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
        UpdateGroupSessionSeats,
        /// <summary>
        /// 
        /// </summary>
        UpdateHoliday,
        /// <summary>
        /// 
        /// </summary>
        UpdateLocation,
        /// <summary>
        /// 
        /// </summary>
        UpdateProduct,
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
                SMBToolConfigParamsDiscriminatorSmbToolType.CancelCalendarEvent => "cancel_calendar_event",
                SMBToolConfigParamsDiscriminatorSmbToolType.CancelGroupSessionForAll => "cancel_group_session_for_all",
                SMBToolConfigParamsDiscriminatorSmbToolType.CancelGroupSessionRegistration => "cancel_group_session_registration",
                SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability => "check_service_availability",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateAgentRule => "create_agent_rule",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset => "create_asset",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient => "create_client",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment => "create_client_appointment",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientInteraction => "create_client_interaction",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateHoliday => "create_holiday",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateLocation => "create_location",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct => "create_product",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateService => "create_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff => "create_staff",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAgentRule => "delete_agent_rule",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset => "delete_asset",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent => "delete_calendar_event",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient => "delete_client",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClientInteraction => "delete_client_interaction",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteGroupSession => "delete_group_session",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteHoliday => "delete_holiday",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteLocation => "delete_location",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct => "delete_product",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService => "delete_service",
                SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff => "delete_staff",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetAnalyticsSummary => "get_analytics_summary",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetAppointmentByConfirmationNumber => "get_appointment_by_confirmation_number",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingPageSettings => "get_booking_page_settings",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingSlugStatus => "get_booking_slug_status",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments => "get_client_appointments",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone => "get_client_by_phone",
                SMBToolConfigParamsDiscriminatorSmbToolType.GetSchedule => "get_schedule",
                SMBToolConfigParamsDiscriminatorSmbToolType.LeaveMessage => "leave_message",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListAgentRules => "list_agent_rules",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets => "list_assets",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents => "list_calendar_events",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListClientInteractions => "list_client_interactions",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListClients => "list_clients",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListGroupSessions => "list_group_sessions",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListHolidays => "list_holidays",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListLocations => "list_locations",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts => "list_products",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListServices => "list_services",
                SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff => "list_staff",
                SMBToolConfigParamsDiscriminatorSmbToolType.RegisterForGroupSession => "register_for_group_session",
                SMBToolConfigParamsDiscriminatorSmbToolType.ScheduleGroupSession => "schedule_group_session",
                SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients => "search_clients",
                SMBToolConfigParamsDiscriminatorSmbToolType.SetBookingSlug => "set_booking_slug",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAgentRule => "update_agent_rule",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset => "update_asset",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBookingPageSettings => "update_booking_page_settings",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBusinessInfo => "update_business_info",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent => "update_calendar_event",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient => "update_client",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCustomerFacingConfig => "update_customer_facing_config",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateGroupSessionSeats => "update_group_session_seats",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateHoliday => "update_holiday",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateLocation => "update_location",
                SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct => "update_product",
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
                "cancel_calendar_event" => SMBToolConfigParamsDiscriminatorSmbToolType.CancelCalendarEvent,
                "cancel_group_session_for_all" => SMBToolConfigParamsDiscriminatorSmbToolType.CancelGroupSessionForAll,
                "cancel_group_session_registration" => SMBToolConfigParamsDiscriminatorSmbToolType.CancelGroupSessionRegistration,
                "check_service_availability" => SMBToolConfigParamsDiscriminatorSmbToolType.CheckServiceAvailability,
                "create_agent_rule" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateAgentRule,
                "create_asset" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateAsset,
                "create_client" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateClient,
                "create_client_appointment" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientAppointment,
                "create_client_interaction" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateClientInteraction,
                "create_holiday" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateHoliday,
                "create_location" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateLocation,
                "create_product" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateProduct,
                "create_service" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateService,
                "create_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.CreateStaff,
                "delete_agent_rule" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAgentRule,
                "delete_asset" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteAsset,
                "delete_calendar_event" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteCalendarEvent,
                "delete_client" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClient,
                "delete_client_interaction" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteClientInteraction,
                "delete_group_session" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteGroupSession,
                "delete_holiday" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteHoliday,
                "delete_location" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteLocation,
                "delete_product" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteProduct,
                "delete_service" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteService,
                "delete_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.DeleteStaff,
                "get_analytics_summary" => SMBToolConfigParamsDiscriminatorSmbToolType.GetAnalyticsSummary,
                "get_appointment_by_confirmation_number" => SMBToolConfigParamsDiscriminatorSmbToolType.GetAppointmentByConfirmationNumber,
                "get_booking_page_settings" => SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingPageSettings,
                "get_booking_slug_status" => SMBToolConfigParamsDiscriminatorSmbToolType.GetBookingSlugStatus,
                "get_client_appointments" => SMBToolConfigParamsDiscriminatorSmbToolType.GetClientAppointments,
                "get_client_by_phone" => SMBToolConfigParamsDiscriminatorSmbToolType.GetClientByPhone,
                "get_schedule" => SMBToolConfigParamsDiscriminatorSmbToolType.GetSchedule,
                "leave_message" => SMBToolConfigParamsDiscriminatorSmbToolType.LeaveMessage,
                "list_agent_rules" => SMBToolConfigParamsDiscriminatorSmbToolType.ListAgentRules,
                "list_assets" => SMBToolConfigParamsDiscriminatorSmbToolType.ListAssets,
                "list_calendar_events" => SMBToolConfigParamsDiscriminatorSmbToolType.ListCalendarEvents,
                "list_client_interactions" => SMBToolConfigParamsDiscriminatorSmbToolType.ListClientInteractions,
                "list_clients" => SMBToolConfigParamsDiscriminatorSmbToolType.ListClients,
                "list_group_sessions" => SMBToolConfigParamsDiscriminatorSmbToolType.ListGroupSessions,
                "list_holidays" => SMBToolConfigParamsDiscriminatorSmbToolType.ListHolidays,
                "list_locations" => SMBToolConfigParamsDiscriminatorSmbToolType.ListLocations,
                "list_products" => SMBToolConfigParamsDiscriminatorSmbToolType.ListProducts,
                "list_services" => SMBToolConfigParamsDiscriminatorSmbToolType.ListServices,
                "list_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.ListStaff,
                "register_for_group_session" => SMBToolConfigParamsDiscriminatorSmbToolType.RegisterForGroupSession,
                "schedule_group_session" => SMBToolConfigParamsDiscriminatorSmbToolType.ScheduleGroupSession,
                "search_clients" => SMBToolConfigParamsDiscriminatorSmbToolType.SearchClients,
                "set_booking_slug" => SMBToolConfigParamsDiscriminatorSmbToolType.SetBookingSlug,
                "update_agent_rule" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAgentRule,
                "update_asset" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateAsset,
                "update_booking_page_settings" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBookingPageSettings,
                "update_business_info" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateBusinessInfo,
                "update_calendar_event" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCalendarEvent,
                "update_client" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateClient,
                "update_customer_facing_config" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateCustomerFacingConfig,
                "update_group_session_seats" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateGroupSessionSeats,
                "update_holiday" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateHoliday,
                "update_location" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateLocation,
                "update_product" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateProduct,
                "update_service" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateService,
                "update_staff" => SMBToolConfigParamsDiscriminatorSmbToolType.UpdateStaff,
                _ => null,
            };
        }
    }
}