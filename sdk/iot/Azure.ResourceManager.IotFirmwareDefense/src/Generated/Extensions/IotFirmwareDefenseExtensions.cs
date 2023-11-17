// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.IotFirmwareDefense.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IotFirmwareDefense
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.IotFirmwareDefense. </summary>
    public static partial class IotFirmwareDefenseExtensions
    {
        private static MockableIotFirmwareDefenseArmClient GetMockableIotFirmwareDefenseArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableIotFirmwareDefenseArmClient(client0));
        }

        private static MockableIotFirmwareDefenseResourceGroupResource GetMockableIotFirmwareDefenseResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableIotFirmwareDefenseResourceGroupResource(client, resource.Id));
        }

        private static MockableIotFirmwareDefenseSubscriptionResource GetMockableIotFirmwareDefenseSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableIotFirmwareDefenseSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="FirmwareResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirmwareResource.CreateResourceIdentifier" /> to create a <see cref="FirmwareResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotFirmwareDefenseArmClient.GetFirmwareResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="FirmwareResource" /> object. </returns>
        public static FirmwareResource GetFirmwareResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableIotFirmwareDefenseArmClient(client).GetFirmwareResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FirmwareWorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirmwareWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="FirmwareWorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotFirmwareDefenseArmClient.GetFirmwareWorkspaceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="FirmwareWorkspaceResource" /> object. </returns>
        public static FirmwareWorkspaceResource GetFirmwareWorkspaceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableIotFirmwareDefenseArmClient(client).GetFirmwareWorkspaceResource(id);
        }

        /// <summary>
        /// Gets a collection of FirmwareWorkspaceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotFirmwareDefenseResourceGroupResource.GetFirmwareWorkspaces()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of FirmwareWorkspaceResources and their operations over a FirmwareWorkspaceResource. </returns>
        public static FirmwareWorkspaceCollection GetFirmwareWorkspaces(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableIotFirmwareDefenseResourceGroupResource(resourceGroupResource).GetFirmwareWorkspaces();
        }

        /// <summary>
        /// Get firmware analysis workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotFirmwareDefenseResourceGroupResource.GetFirmwareWorkspaceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FirmwareWorkspaceResource>> GetFirmwareWorkspaceAsync(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableIotFirmwareDefenseResourceGroupResource(resourceGroupResource).GetFirmwareWorkspaceAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get firmware analysis workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotFirmwareDefenseResourceGroupResource.GetFirmwareWorkspace(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<FirmwareWorkspaceResource> GetFirmwareWorkspace(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableIotFirmwareDefenseResourceGroupResource(resourceGroupResource).GetFirmwareWorkspace(workspaceName, cancellationToken);
        }

        /// <summary>
        /// Lists all of the firmware analysis workspaces in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTFirmwareDefense/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotFirmwareDefenseSubscriptionResource.GetFirmwareWorkspaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="FirmwareWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<FirmwareWorkspaceResource> GetFirmwareWorkspacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableIotFirmwareDefenseSubscriptionResource(subscriptionResource).GetFirmwareWorkspacesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all of the firmware analysis workspaces in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTFirmwareDefense/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotFirmwareDefenseSubscriptionResource.GetFirmwareWorkspaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="FirmwareWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<FirmwareWorkspaceResource> GetFirmwareWorkspaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableIotFirmwareDefenseSubscriptionResource(subscriptionResource).GetFirmwareWorkspaces(cancellationToken);
        }
    }
}
