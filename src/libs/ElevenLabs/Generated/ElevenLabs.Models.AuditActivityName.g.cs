
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Audit log `activity_name` values that can be stored in a customer workspace's audit log.
    /// </summary>
    public enum AuditActivityName
    {
        /// <summary>
        ///
        /// </summary>
        ApiKeyCreation,
        /// <summary>
        ///
        /// </summary>
        ApiKeyDeletion,
        /// <summary>
        ///
        /// </summary>
        ApiKeyManagement,
        /// <summary>
        ///
        /// </summary>
        ApiKeyUpdate,
        /// <summary>
        ///
        /// </summary>
        AccountSecurityChange,
        /// <summary>
        ///
        /// </summary>
        AgentsUserMemoryEntityDeleted,
        /// <summary>
        ///
        /// </summary>
        AgentsUserMemoryErased,
        /// <summary>
        ///
        /// </summary>
        AgentsUserMemoryExported,
        /// <summary>
        ///
        /// </summary>
        AgentsUserMemoryFactDeleted,
        /// <summary>
        ///
        /// </summary>
        AgentsUserMemoryViewed,
        /// <summary>
        ///
        /// </summary>
        AgentsUserPropertiesReordered,
        /// <summary>
        ///
        /// </summary>
        AgentsUserPropertyArchived,
        /// <summary>
        ///
        /// </summary>
        AgentsUserPropertyCreated,
        /// <summary>
        ///
        /// </summary>
        AgentsUserPropertyUnarchived,
        /// <summary>
        ///
        /// </summary>
        AgentsUserPropertyUpdated,
        /// <summary>
        ///
        /// </summary>
        ArchitectMemberSpendLimitsUpdate,
        /// <summary>
        ///
        /// </summary>
        AuthConnectionCreation,
        /// <summary>
        ///
        /// </summary>
        AuthConnectionDeletion,
        /// <summary>
        ///
        /// </summary>
        AuthConnectionManagement,
        /// <summary>
        ///
        /// </summary>
        AuthConnectionUpdate,
        /// <summary>
        ///
        /// </summary>
        BillingManagement,
        /// <summary>
        ///
        /// </summary>
        ChildWorkspaceResourceOverride,
        /// <summary>
        ///
        /// </summary>
        ContentGenerationTermsUpdate,
        /// <summary>
        ///
        /// </summary>
        CreateWorkspaceCustomRole,
        /// <summary>
        ///
        /// </summary>
        CustomAuthTokenCreated,
        /// <summary>
        ///
        /// </summary>
        DataExportRequest,
        /// <summary>
        ///
        /// </summary>
        DeleteScribeMeeting,
        /// <summary>
        ///
        /// </summary>
        DeleteWorkspaceCustomRole,
        /// <summary>
        ///
        /// </summary>
        DomainVerificationAddition,
        /// <summary>
        ///
        /// </summary>
        DomainVerificationManagement,
        /// <summary>
        ///
        /// </summary>
        DomainVerificationRemoval,
        /// <summary>
        ///
        /// </summary>
        DomainVerificationStatusUpdate,
        /// <summary>
        ///
        /// </summary>
        EncryptionKeyDeleted,
        /// <summary>
        ///
        /// </summary>
        EncryptionKeyPaused,
        /// <summary>
        ///
        /// </summary>
        EncryptionKeyRegistered,
        /// <summary>
        ///
        /// </summary>
        EncryptionKeyUnpaused,
        /// <summary>
        ///
        /// </summary>
        EnterpriseCopyingToggle,
        /// <summary>
        ///
        /// </summary>
        GiftCreditCodeApplied,
        /// <summary>
        ///
        /// </summary>
        GroupCreation,
        /// <summary>
        ///
        /// </summary>
        GroupDeletion,
        /// <summary>
        ///
        /// </summary>
        GroupManagement,
        /// <summary>
        ///
        /// </summary>
        GroupMemberAddition,
        /// <summary>
        ///
        /// </summary>
        GroupMemberRemoval,
        /// <summary>
        ///
        /// </summary>
        GroupUpdate,
        /// <summary>
        ///
        /// </summary>
        GroupToBillingGroupConversion,
        /// <summary>
        ///
        /// </summary>
        IdentityProviderUpdate,
        /// <summary>
        ///
        /// </summary>
        InAppTermAcceptance,
        /// <summary>
        ///
        /// </summary>
        InfluencerCodeApplied,
        /// <summary>
        ///
        /// </summary>
        Logon,
        /// <summary>
        ///
        /// </summary>
        MfaFactorEnrollment,
        /// <summary>
        ///
        /// </summary>
        MfaFactorEnrollmentRevertedUnverified,
        /// <summary>
        ///
        /// </summary>
        MfaFactorRemoval,
        /// <summary>
        ///
        /// </summary>
        MfaRemovalViaBackupCode,
        /// <summary>
        ///
        /// </summary>
        ModelApprovalsUpdate,
        /// <summary>
        ///
        /// </summary>
        NotificationPreferenceCreation,
        /// <summary>
        ///
        /// </summary>
        NotificationPreferenceDeletion,
        /// <summary>
        ///
        /// </summary>
        NotificationPreferenceManagement,
        /// <summary>
        ///
        /// </summary>
        NotificationPreferenceUpdate,
        /// <summary>
        ///
        /// </summary>
        PasswordResetEmailRequest,
        /// <summary>
        ///
        /// </summary>
        PasswordResetLinkGeneration,
        /// <summary>
        ///
        /// </summary>
        ReportingWorkspaceSsoInheritanceUpdate,
        /// <summary>
        ///
        /// </summary>
        ResourceAccessGranted,
        /// <summary>
        ///
        /// </summary>
        ResourceAccessManagement,
        /// <summary>
        ///
        /// </summary>
        ResourceAccessRevoked,
        /// <summary>
        ///
        /// </summary>
        ResourceCopiedToWorkspace,
        /// <summary>
        ///
        /// </summary>
        ResourceLocatorCreation,
        /// <summary>
        ///
        /// </summary>
        ResourceLocatorDeletion,
        /// <summary>
        ///
        /// </summary>
        ResourceLocatorManagement,
        /// <summary>
        ///
        /// </summary>
        ResourceLocatorUpdate,
        /// <summary>
        ///
        /// </summary>
        ResourceOwnershipTransferred,
        /// <summary>
        ///
        /// </summary>
        ScimGroupCreation,
        /// <summary>
        ///
        /// </summary>
        ScimGroupDeletion,
        /// <summary>
        ///
        /// </summary>
        ScimGroupManagement,
        /// <summary>
        ///
        /// </summary>
        ScimGroupUpdate,
        /// <summary>
        ///
        /// </summary>
        ScimProvisioningSeatTypeUpdated,
        /// <summary>
        ///
        /// </summary>
        ScimTokenDeleted,
        /// <summary>
        ///
        /// </summary>
        ScimTokenGenerated,
        /// <summary>
        ///
        /// </summary>
        ScimTokenManagement,
        /// <summary>
        ///
        /// </summary>
        ScimTokenRotated,
        /// <summary>
        ///
        /// </summary>
        ScimUserCreation,
        /// <summary>
        ///
        /// </summary>
        ScimUserDeletion,
        /// <summary>
        ///
        /// </summary>
        ScimUserManagement,
        /// <summary>
        ///
        /// </summary>
        ScimUserUpdate,
        /// <summary>
        ///
        /// </summary>
        SmbFreeTrialActivation,
        /// <summary>
        ///
        /// </summary>
        SmbResellerSubscriptionLifecycle,
        /// <summary>
        ///
        /// </summary>
        SmbResellerTierAssignment,
        /// <summary>
        ///
        /// </summary>
        SmbResellerTierChange,
        /// <summary>
        ///
        /// </summary>
        SsoManagement,
        /// <summary>
        ///
        /// </summary>
        SsoProviderConfiguration,
        /// <summary>
        ///
        /// </summary>
        SsoProviderRemoval,
        /// <summary>
        ///
        /// </summary>
        SensitiveActionVerification,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountCreation,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountDeletion,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountManagement,
        /// <summary>
        ///
        /// </summary>
        ServiceAccountUpdate,
        /// <summary>
        ///
        /// </summary>
        SharedSsoSiblingWorkspacesUpdate,
        /// <summary>
        ///
        /// </summary>
        SignInRequestApproval,
        /// <summary>
        ///
        /// </summary>
        SignInRequestDecline,
        /// <summary>
        ///
        /// </summary>
        UpdateWorkspaceCustomRole,
        /// <summary>
        ///
        /// </summary>
        UserApiKeyCreation,
        /// <summary>
        ///
        /// </summary>
        UserApiKeyDeletion,
        /// <summary>
        ///
        /// </summary>
        UserApiKeyManagement,
        /// <summary>
        ///
        /// </summary>
        UserApiKeyUpdate,
        /// <summary>
        ///
        /// </summary>
        UserAutoProvisioningDisabled,
        /// <summary>
        ///
        /// </summary>
        UserAutoProvisioningEnabled,
        /// <summary>
        ///
        /// </summary>
        UserCreation,
        /// <summary>
        ///
        /// </summary>
        UserMetadataUpdate,
        /// <summary>
        ///
        /// </summary>
        UserSelfDeletion,
        /// <summary>
        ///
        /// </summary>
        UserSharingPreferencesUpdate,
        /// <summary>
        ///
        /// </summary>
        UserSharingPreferencesUpdateAdmin,
        /// <summary>
        ///
        /// </summary>
        WebhookCreation,
        /// <summary>
        ///
        /// </summary>
        WebhookDeletion,
        /// <summary>
        ///
        /// </summary>
        WebhookManagement,
        /// <summary>
        ///
        /// </summary>
        WebhookUpdate,
        /// <summary>
        ///
        /// </summary>
        WorkspaceCreation,
        /// <summary>
        ///
        /// </summary>
        WorkspaceDeletion,
        /// <summary>
        ///
        /// </summary>
        WorkspaceDeletionCancellation,
        /// <summary>
        ///
        /// </summary>
        WorkspaceInvitationAccepted,
        /// <summary>
        ///
        /// </summary>
        WorkspaceInvitationDeclined,
        /// <summary>
        ///
        /// </summary>
        WorkspaceInvitationManagement,
        /// <summary>
        ///
        /// </summary>
        WorkspaceInvitationReminderSent,
        /// <summary>
        ///
        /// </summary>
        WorkspaceInvitationRevoked,
        /// <summary>
        ///
        /// </summary>
        WorkspaceInvitationSent,
        /// <summary>
        ///
        /// </summary>
        WorkspaceMemberRemoval,
        /// <summary>
        ///
        /// </summary>
        WorkspaceMemberResourceTransfer,
        /// <summary>
        ///
        /// </summary>
        WorkspaceMemberUpdate,
        /// <summary>
        ///
        /// </summary>
        WorkspaceMemberUsageLimitUpdate,
        /// <summary>
        ///
        /// </summary>
        WorkspaceMetadataUpdate,
        /// <summary>
        ///
        /// </summary>
        WorkspaceOwnershipTransfer,
        /// <summary>
        ///
        /// </summary>
        WorkspaceSignIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditActivityNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditActivityName value)
        {
            return value switch
            {
                AuditActivityName.ApiKeyCreation => "API Key Creation",
                AuditActivityName.ApiKeyDeletion => "API Key Deletion",
                AuditActivityName.ApiKeyManagement => "API Key Management",
                AuditActivityName.ApiKeyUpdate => "API Key Update",
                AuditActivityName.AccountSecurityChange => "Account Security Change",
                AuditActivityName.AgentsUserMemoryEntityDeleted => "Agents User Memory Entity Deleted",
                AuditActivityName.AgentsUserMemoryErased => "Agents User Memory Erased",
                AuditActivityName.AgentsUserMemoryExported => "Agents User Memory Exported",
                AuditActivityName.AgentsUserMemoryFactDeleted => "Agents User Memory Fact Deleted",
                AuditActivityName.AgentsUserMemoryViewed => "Agents User Memory Viewed",
                AuditActivityName.AgentsUserPropertiesReordered => "Agents User Properties Reordered",
                AuditActivityName.AgentsUserPropertyArchived => "Agents User Property Archived",
                AuditActivityName.AgentsUserPropertyCreated => "Agents User Property Created",
                AuditActivityName.AgentsUserPropertyUnarchived => "Agents User Property Unarchived",
                AuditActivityName.AgentsUserPropertyUpdated => "Agents User Property Updated",
                AuditActivityName.ArchitectMemberSpendLimitsUpdate => "Architect Member Spend Limits Update",
                AuditActivityName.AuthConnectionCreation => "Auth Connection Creation",
                AuditActivityName.AuthConnectionDeletion => "Auth Connection Deletion",
                AuditActivityName.AuthConnectionManagement => "Auth Connection Management",
                AuditActivityName.AuthConnectionUpdate => "Auth Connection Update",
                AuditActivityName.BillingManagement => "Billing Management",
                AuditActivityName.ChildWorkspaceResourceOverride => "Child Workspace Resource Override",
                AuditActivityName.ContentGenerationTermsUpdate => "Content Generation Terms Update",
                AuditActivityName.CreateWorkspaceCustomRole => "Create workspace custom role",
                AuditActivityName.CustomAuthTokenCreated => "Custom Auth Token Created",
                AuditActivityName.DataExportRequest => "Data Export Request",
                AuditActivityName.DeleteScribeMeeting => "Delete Scribe meeting",
                AuditActivityName.DeleteWorkspaceCustomRole => "Delete workspace custom role",
                AuditActivityName.DomainVerificationAddition => "Domain Verification Addition",
                AuditActivityName.DomainVerificationManagement => "Domain Verification Management",
                AuditActivityName.DomainVerificationRemoval => "Domain Verification Removal",
                AuditActivityName.DomainVerificationStatusUpdate => "Domain Verification Status Update",
                AuditActivityName.EncryptionKeyDeleted => "Encryption Key Deleted",
                AuditActivityName.EncryptionKeyPaused => "Encryption Key Paused",
                AuditActivityName.EncryptionKeyRegistered => "Encryption Key Registered",
                AuditActivityName.EncryptionKeyUnpaused => "Encryption Key Unpaused",
                AuditActivityName.EnterpriseCopyingToggle => "Enterprise Copying Toggle",
                AuditActivityName.GiftCreditCodeApplied => "Gift Credit Code Applied",
                AuditActivityName.GroupCreation => "Group Creation",
                AuditActivityName.GroupDeletion => "Group Deletion",
                AuditActivityName.GroupManagement => "Group Management",
                AuditActivityName.GroupMemberAddition => "Group Member Addition",
                AuditActivityName.GroupMemberRemoval => "Group Member Removal",
                AuditActivityName.GroupUpdate => "Group Update",
                AuditActivityName.GroupToBillingGroupConversion => "Group to Billing Group Conversion",
                AuditActivityName.IdentityProviderUpdate => "Identity Provider Update",
                AuditActivityName.InAppTermAcceptance => "In-App Term Acceptance",
                AuditActivityName.InfluencerCodeApplied => "Influencer Code Applied",
                AuditActivityName.Logon => "Logon",
                AuditActivityName.MfaFactorEnrollment => "MFA Factor Enrollment",
                AuditActivityName.MfaFactorEnrollmentRevertedUnverified => "MFA Factor Enrollment Reverted (unverified)",
                AuditActivityName.MfaFactorRemoval => "MFA Factor Removal",
                AuditActivityName.MfaRemovalViaBackupCode => "MFA Removal via Backup Code",
                AuditActivityName.ModelApprovalsUpdate => "Model Approvals Update",
                AuditActivityName.NotificationPreferenceCreation => "Notification Preference Creation",
                AuditActivityName.NotificationPreferenceDeletion => "Notification Preference Deletion",
                AuditActivityName.NotificationPreferenceManagement => "Notification Preference Management",
                AuditActivityName.NotificationPreferenceUpdate => "Notification Preference Update",
                AuditActivityName.PasswordResetEmailRequest => "Password Reset Email Request",
                AuditActivityName.PasswordResetLinkGeneration => "Password Reset Link Generation",
                AuditActivityName.ReportingWorkspaceSsoInheritanceUpdate => "Reporting Workspace SSO Inheritance Update",
                AuditActivityName.ResourceAccessGranted => "Resource Access Granted",
                AuditActivityName.ResourceAccessManagement => "Resource Access Management",
                AuditActivityName.ResourceAccessRevoked => "Resource Access Revoked",
                AuditActivityName.ResourceCopiedToWorkspace => "Resource Copied to Workspace",
                AuditActivityName.ResourceLocatorCreation => "Resource Locator Creation",
                AuditActivityName.ResourceLocatorDeletion => "Resource Locator Deletion",
                AuditActivityName.ResourceLocatorManagement => "Resource Locator Management",
                AuditActivityName.ResourceLocatorUpdate => "Resource Locator Update",
                AuditActivityName.ResourceOwnershipTransferred => "Resource Ownership Transferred",
                AuditActivityName.ScimGroupCreation => "SCIM Group Creation",
                AuditActivityName.ScimGroupDeletion => "SCIM Group Deletion",
                AuditActivityName.ScimGroupManagement => "SCIM Group Management",
                AuditActivityName.ScimGroupUpdate => "SCIM Group Update",
                AuditActivityName.ScimProvisioningSeatTypeUpdated => "SCIM Provisioning Seat Type Updated",
                AuditActivityName.ScimTokenDeleted => "SCIM Token Deleted",
                AuditActivityName.ScimTokenGenerated => "SCIM Token Generated",
                AuditActivityName.ScimTokenManagement => "SCIM Token Management",
                AuditActivityName.ScimTokenRotated => "SCIM Token Rotated",
                AuditActivityName.ScimUserCreation => "SCIM User Creation",
                AuditActivityName.ScimUserDeletion => "SCIM User Deletion",
                AuditActivityName.ScimUserManagement => "SCIM User Management",
                AuditActivityName.ScimUserUpdate => "SCIM User Update",
                AuditActivityName.SmbFreeTrialActivation => "SMB Free Trial Activation",
                AuditActivityName.SmbResellerSubscriptionLifecycle => "SMB Reseller Subscription Lifecycle",
                AuditActivityName.SmbResellerTierAssignment => "SMB Reseller Tier Assignment",
                AuditActivityName.SmbResellerTierChange => "SMB Reseller Tier Change",
                AuditActivityName.SsoManagement => "SSO Management",
                AuditActivityName.SsoProviderConfiguration => "SSO Provider Configuration",
                AuditActivityName.SsoProviderRemoval => "SSO Provider Removal",
                AuditActivityName.SensitiveActionVerification => "Sensitive Action Verification",
                AuditActivityName.ServiceAccountCreation => "Service Account Creation",
                AuditActivityName.ServiceAccountDeletion => "Service Account Deletion",
                AuditActivityName.ServiceAccountManagement => "Service Account Management",
                AuditActivityName.ServiceAccountUpdate => "Service Account Update",
                AuditActivityName.SharedSsoSiblingWorkspacesUpdate => "Shared SSO Sibling Workspaces Update",
                AuditActivityName.SignInRequestApproval => "Sign-In Request Approval",
                AuditActivityName.SignInRequestDecline => "Sign-In Request Decline",
                AuditActivityName.UpdateWorkspaceCustomRole => "Update workspace custom role",
                AuditActivityName.UserApiKeyCreation => "User API Key Creation",
                AuditActivityName.UserApiKeyDeletion => "User API Key Deletion",
                AuditActivityName.UserApiKeyManagement => "User API Key Management",
                AuditActivityName.UserApiKeyUpdate => "User API Key Update",
                AuditActivityName.UserAutoProvisioningDisabled => "User Auto-Provisioning Disabled",
                AuditActivityName.UserAutoProvisioningEnabled => "User Auto-Provisioning Enabled",
                AuditActivityName.UserCreation => "User Creation",
                AuditActivityName.UserMetadataUpdate => "User Metadata Update",
                AuditActivityName.UserSelfDeletion => "User Self-Deletion",
                AuditActivityName.UserSharingPreferencesUpdate => "User Sharing Preferences Update",
                AuditActivityName.UserSharingPreferencesUpdateAdmin => "User Sharing Preferences Update (Admin)",
                AuditActivityName.WebhookCreation => "Webhook Creation",
                AuditActivityName.WebhookDeletion => "Webhook Deletion",
                AuditActivityName.WebhookManagement => "Webhook Management",
                AuditActivityName.WebhookUpdate => "Webhook Update",
                AuditActivityName.WorkspaceCreation => "Workspace Creation",
                AuditActivityName.WorkspaceDeletion => "Workspace Deletion",
                AuditActivityName.WorkspaceDeletionCancellation => "Workspace Deletion Cancellation",
                AuditActivityName.WorkspaceInvitationAccepted => "Workspace Invitation Accepted",
                AuditActivityName.WorkspaceInvitationDeclined => "Workspace Invitation Declined",
                AuditActivityName.WorkspaceInvitationManagement => "Workspace Invitation Management",
                AuditActivityName.WorkspaceInvitationReminderSent => "Workspace Invitation Reminder Sent",
                AuditActivityName.WorkspaceInvitationRevoked => "Workspace Invitation Revoked",
                AuditActivityName.WorkspaceInvitationSent => "Workspace Invitation Sent",
                AuditActivityName.WorkspaceMemberRemoval => "Workspace Member Removal",
                AuditActivityName.WorkspaceMemberResourceTransfer => "Workspace Member Resource Transfer",
                AuditActivityName.WorkspaceMemberUpdate => "Workspace Member Update",
                AuditActivityName.WorkspaceMemberUsageLimitUpdate => "Workspace Member Usage Limit Update",
                AuditActivityName.WorkspaceMetadataUpdate => "Workspace Metadata Update",
                AuditActivityName.WorkspaceOwnershipTransfer => "Workspace Ownership Transfer",
                AuditActivityName.WorkspaceSignIn => "Workspace Sign-In",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditActivityName? ToEnum(string value)
        {
            return value switch
            {
                "API Key Creation" => AuditActivityName.ApiKeyCreation,
                "API Key Deletion" => AuditActivityName.ApiKeyDeletion,
                "API Key Management" => AuditActivityName.ApiKeyManagement,
                "API Key Update" => AuditActivityName.ApiKeyUpdate,
                "Account Security Change" => AuditActivityName.AccountSecurityChange,
                "Agents User Memory Entity Deleted" => AuditActivityName.AgentsUserMemoryEntityDeleted,
                "Agents User Memory Erased" => AuditActivityName.AgentsUserMemoryErased,
                "Agents User Memory Exported" => AuditActivityName.AgentsUserMemoryExported,
                "Agents User Memory Fact Deleted" => AuditActivityName.AgentsUserMemoryFactDeleted,
                "Agents User Memory Viewed" => AuditActivityName.AgentsUserMemoryViewed,
                "Agents User Properties Reordered" => AuditActivityName.AgentsUserPropertiesReordered,
                "Agents User Property Archived" => AuditActivityName.AgentsUserPropertyArchived,
                "Agents User Property Created" => AuditActivityName.AgentsUserPropertyCreated,
                "Agents User Property Unarchived" => AuditActivityName.AgentsUserPropertyUnarchived,
                "Agents User Property Updated" => AuditActivityName.AgentsUserPropertyUpdated,
                "Architect Member Spend Limits Update" => AuditActivityName.ArchitectMemberSpendLimitsUpdate,
                "Auth Connection Creation" => AuditActivityName.AuthConnectionCreation,
                "Auth Connection Deletion" => AuditActivityName.AuthConnectionDeletion,
                "Auth Connection Management" => AuditActivityName.AuthConnectionManagement,
                "Auth Connection Update" => AuditActivityName.AuthConnectionUpdate,
                "Billing Management" => AuditActivityName.BillingManagement,
                "Child Workspace Resource Override" => AuditActivityName.ChildWorkspaceResourceOverride,
                "Content Generation Terms Update" => AuditActivityName.ContentGenerationTermsUpdate,
                "Create workspace custom role" => AuditActivityName.CreateWorkspaceCustomRole,
                "Custom Auth Token Created" => AuditActivityName.CustomAuthTokenCreated,
                "Data Export Request" => AuditActivityName.DataExportRequest,
                "Delete Scribe meeting" => AuditActivityName.DeleteScribeMeeting,
                "Delete workspace custom role" => AuditActivityName.DeleteWorkspaceCustomRole,
                "Domain Verification Addition" => AuditActivityName.DomainVerificationAddition,
                "Domain Verification Management" => AuditActivityName.DomainVerificationManagement,
                "Domain Verification Removal" => AuditActivityName.DomainVerificationRemoval,
                "Domain Verification Status Update" => AuditActivityName.DomainVerificationStatusUpdate,
                "Encryption Key Deleted" => AuditActivityName.EncryptionKeyDeleted,
                "Encryption Key Paused" => AuditActivityName.EncryptionKeyPaused,
                "Encryption Key Registered" => AuditActivityName.EncryptionKeyRegistered,
                "Encryption Key Unpaused" => AuditActivityName.EncryptionKeyUnpaused,
                "Enterprise Copying Toggle" => AuditActivityName.EnterpriseCopyingToggle,
                "Gift Credit Code Applied" => AuditActivityName.GiftCreditCodeApplied,
                "Group Creation" => AuditActivityName.GroupCreation,
                "Group Deletion" => AuditActivityName.GroupDeletion,
                "Group Management" => AuditActivityName.GroupManagement,
                "Group Member Addition" => AuditActivityName.GroupMemberAddition,
                "Group Member Removal" => AuditActivityName.GroupMemberRemoval,
                "Group Update" => AuditActivityName.GroupUpdate,
                "Group to Billing Group Conversion" => AuditActivityName.GroupToBillingGroupConversion,
                "Identity Provider Update" => AuditActivityName.IdentityProviderUpdate,
                "In-App Term Acceptance" => AuditActivityName.InAppTermAcceptance,
                "Influencer Code Applied" => AuditActivityName.InfluencerCodeApplied,
                "Logon" => AuditActivityName.Logon,
                "MFA Factor Enrollment" => AuditActivityName.MfaFactorEnrollment,
                "MFA Factor Enrollment Reverted (unverified)" => AuditActivityName.MfaFactorEnrollmentRevertedUnverified,
                "MFA Factor Removal" => AuditActivityName.MfaFactorRemoval,
                "MFA Removal via Backup Code" => AuditActivityName.MfaRemovalViaBackupCode,
                "Model Approvals Update" => AuditActivityName.ModelApprovalsUpdate,
                "Notification Preference Creation" => AuditActivityName.NotificationPreferenceCreation,
                "Notification Preference Deletion" => AuditActivityName.NotificationPreferenceDeletion,
                "Notification Preference Management" => AuditActivityName.NotificationPreferenceManagement,
                "Notification Preference Update" => AuditActivityName.NotificationPreferenceUpdate,
                "Password Reset Email Request" => AuditActivityName.PasswordResetEmailRequest,
                "Password Reset Link Generation" => AuditActivityName.PasswordResetLinkGeneration,
                "Reporting Workspace SSO Inheritance Update" => AuditActivityName.ReportingWorkspaceSsoInheritanceUpdate,
                "Resource Access Granted" => AuditActivityName.ResourceAccessGranted,
                "Resource Access Management" => AuditActivityName.ResourceAccessManagement,
                "Resource Access Revoked" => AuditActivityName.ResourceAccessRevoked,
                "Resource Copied to Workspace" => AuditActivityName.ResourceCopiedToWorkspace,
                "Resource Locator Creation" => AuditActivityName.ResourceLocatorCreation,
                "Resource Locator Deletion" => AuditActivityName.ResourceLocatorDeletion,
                "Resource Locator Management" => AuditActivityName.ResourceLocatorManagement,
                "Resource Locator Update" => AuditActivityName.ResourceLocatorUpdate,
                "Resource Ownership Transferred" => AuditActivityName.ResourceOwnershipTransferred,
                "SCIM Group Creation" => AuditActivityName.ScimGroupCreation,
                "SCIM Group Deletion" => AuditActivityName.ScimGroupDeletion,
                "SCIM Group Management" => AuditActivityName.ScimGroupManagement,
                "SCIM Group Update" => AuditActivityName.ScimGroupUpdate,
                "SCIM Provisioning Seat Type Updated" => AuditActivityName.ScimProvisioningSeatTypeUpdated,
                "SCIM Token Deleted" => AuditActivityName.ScimTokenDeleted,
                "SCIM Token Generated" => AuditActivityName.ScimTokenGenerated,
                "SCIM Token Management" => AuditActivityName.ScimTokenManagement,
                "SCIM Token Rotated" => AuditActivityName.ScimTokenRotated,
                "SCIM User Creation" => AuditActivityName.ScimUserCreation,
                "SCIM User Deletion" => AuditActivityName.ScimUserDeletion,
                "SCIM User Management" => AuditActivityName.ScimUserManagement,
                "SCIM User Update" => AuditActivityName.ScimUserUpdate,
                "SMB Free Trial Activation" => AuditActivityName.SmbFreeTrialActivation,
                "SMB Reseller Subscription Lifecycle" => AuditActivityName.SmbResellerSubscriptionLifecycle,
                "SMB Reseller Tier Assignment" => AuditActivityName.SmbResellerTierAssignment,
                "SMB Reseller Tier Change" => AuditActivityName.SmbResellerTierChange,
                "SSO Management" => AuditActivityName.SsoManagement,
                "SSO Provider Configuration" => AuditActivityName.SsoProviderConfiguration,
                "SSO Provider Removal" => AuditActivityName.SsoProviderRemoval,
                "Sensitive Action Verification" => AuditActivityName.SensitiveActionVerification,
                "Service Account Creation" => AuditActivityName.ServiceAccountCreation,
                "Service Account Deletion" => AuditActivityName.ServiceAccountDeletion,
                "Service Account Management" => AuditActivityName.ServiceAccountManagement,
                "Service Account Update" => AuditActivityName.ServiceAccountUpdate,
                "Shared SSO Sibling Workspaces Update" => AuditActivityName.SharedSsoSiblingWorkspacesUpdate,
                "Sign-In Request Approval" => AuditActivityName.SignInRequestApproval,
                "Sign-In Request Decline" => AuditActivityName.SignInRequestDecline,
                "Update workspace custom role" => AuditActivityName.UpdateWorkspaceCustomRole,
                "User API Key Creation" => AuditActivityName.UserApiKeyCreation,
                "User API Key Deletion" => AuditActivityName.UserApiKeyDeletion,
                "User API Key Management" => AuditActivityName.UserApiKeyManagement,
                "User API Key Update" => AuditActivityName.UserApiKeyUpdate,
                "User Auto-Provisioning Disabled" => AuditActivityName.UserAutoProvisioningDisabled,
                "User Auto-Provisioning Enabled" => AuditActivityName.UserAutoProvisioningEnabled,
                "User Creation" => AuditActivityName.UserCreation,
                "User Metadata Update" => AuditActivityName.UserMetadataUpdate,
                "User Self-Deletion" => AuditActivityName.UserSelfDeletion,
                "User Sharing Preferences Update" => AuditActivityName.UserSharingPreferencesUpdate,
                "User Sharing Preferences Update (Admin)" => AuditActivityName.UserSharingPreferencesUpdateAdmin,
                "Webhook Creation" => AuditActivityName.WebhookCreation,
                "Webhook Deletion" => AuditActivityName.WebhookDeletion,
                "Webhook Management" => AuditActivityName.WebhookManagement,
                "Webhook Update" => AuditActivityName.WebhookUpdate,
                "Workspace Creation" => AuditActivityName.WorkspaceCreation,
                "Workspace Deletion" => AuditActivityName.WorkspaceDeletion,
                "Workspace Deletion Cancellation" => AuditActivityName.WorkspaceDeletionCancellation,
                "Workspace Invitation Accepted" => AuditActivityName.WorkspaceInvitationAccepted,
                "Workspace Invitation Declined" => AuditActivityName.WorkspaceInvitationDeclined,
                "Workspace Invitation Management" => AuditActivityName.WorkspaceInvitationManagement,
                "Workspace Invitation Reminder Sent" => AuditActivityName.WorkspaceInvitationReminderSent,
                "Workspace Invitation Revoked" => AuditActivityName.WorkspaceInvitationRevoked,
                "Workspace Invitation Sent" => AuditActivityName.WorkspaceInvitationSent,
                "Workspace Member Removal" => AuditActivityName.WorkspaceMemberRemoval,
                "Workspace Member Resource Transfer" => AuditActivityName.WorkspaceMemberResourceTransfer,
                "Workspace Member Update" => AuditActivityName.WorkspaceMemberUpdate,
                "Workspace Member Usage Limit Update" => AuditActivityName.WorkspaceMemberUsageLimitUpdate,
                "Workspace Metadata Update" => AuditActivityName.WorkspaceMetadataUpdate,
                "Workspace Ownership Transfer" => AuditActivityName.WorkspaceOwnershipTransfer,
                "Workspace Sign-In" => AuditActivityName.WorkspaceSignIn,
                _ => null,
            };
        }
    }
}