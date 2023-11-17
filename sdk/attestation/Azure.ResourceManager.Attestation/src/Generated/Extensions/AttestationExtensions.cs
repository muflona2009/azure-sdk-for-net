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
using Azure.ResourceManager.Attestation.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Attestation
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Attestation. </summary>
    public static partial class AttestationExtensions
    {
        private static MockableAttestationArmClient GetMockableAttestationArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableAttestationArmClient(client0));
        }

        private static MockableAttestationResourceGroupResource GetMockableAttestationResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableAttestationResourceGroupResource(client, resource.Id));
        }

        private static MockableAttestationSubscriptionResource GetMockableAttestationSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableAttestationSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="AttestationProviderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AttestationProviderResource.CreateResourceIdentifier" /> to create an <see cref="AttestationProviderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationArmClient.GetAttestationProviderResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AttestationProviderResource" /> object. </returns>
        public static AttestationProviderResource GetAttestationProviderResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAttestationArmClient(client).GetAttestationProviderResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AttestationPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AttestationPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="AttestationPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationArmClient.GetAttestationPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AttestationPrivateEndpointConnectionResource" /> object. </returns>
        public static AttestationPrivateEndpointConnectionResource GetAttestationPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAttestationArmClient(client).GetAttestationPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets a collection of AttestationProviderResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationResourceGroupResource.GetAttestationProviders()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of AttestationProviderResources and their operations over a AttestationProviderResource. </returns>
        public static AttestationProviderCollection GetAttestationProviders(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableAttestationResourceGroupResource(resourceGroupResource).GetAttestationProviders();
        }

        /// <summary>
        /// Get the status of Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationResourceGroupResource.GetAttestationProviderAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="providerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AttestationProviderResource>> GetAttestationProviderAsync(this ResourceGroupResource resourceGroupResource, string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableAttestationResourceGroupResource(resourceGroupResource).GetAttestationProviderAsync(providerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the status of Attestation Provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProviders/{providerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationResourceGroupResource.GetAttestationProvider(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> Name of the attestation provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="providerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<AttestationProviderResource> GetAttestationProvider(this ResourceGroupResource resourceGroupResource, string providerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableAttestationResourceGroupResource(resourceGroupResource).GetAttestationProvider(providerName, cancellationToken);
        }

        /// <summary>
        /// Returns a list of attestation providers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationSubscriptionResource.GetAttestationProviders(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AttestationProviderResource> GetAttestationProvidersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAttestationSubscriptionResource(subscriptionResource).GetAttestationProvidersAsync(cancellationToken);
        }

        /// <summary>
        /// Returns a list of attestation providers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/attestationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationSubscriptionResource.GetAttestationProviders(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AttestationProviderResource> GetAttestationProviders(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAttestationSubscriptionResource(subscriptionResource).GetAttestationProviders(cancellationToken);
        }

        /// <summary>
        /// Get the default provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/defaultProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_ListDefault</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationSubscriptionResource.GetAttestationProvidersByDefaultProvider(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AttestationProviderResource> GetAttestationProvidersByDefaultProviderAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAttestationSubscriptionResource(subscriptionResource).GetAttestationProvidersByDefaultProviderAsync(cancellationToken);
        }

        /// <summary>
        /// Get the default provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/defaultProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_ListDefault</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationSubscriptionResource.GetAttestationProvidersByDefaultProvider(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="AttestationProviderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AttestationProviderResource> GetAttestationProvidersByDefaultProvider(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAttestationSubscriptionResource(subscriptionResource).GetAttestationProvidersByDefaultProvider(cancellationToken);
        }

        /// <summary>
        /// Get the default provider by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/locations/{location}/defaultProvider</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_GetDefaultByLocation</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationSubscriptionResource.GetDefaultByLocationAttestationProvider(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the default provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        public static async Task<Response<AttestationProviderResource>> GetDefaultByLocationAttestationProviderAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableAttestationSubscriptionResource(subscriptionResource).GetDefaultByLocationAttestationProviderAsync(location, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the default provider by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Attestation/locations/{location}/defaultProvider</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AttestationProviders_GetDefaultByLocation</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAttestationSubscriptionResource.GetDefaultByLocationAttestationProvider(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the default provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        public static Response<AttestationProviderResource> GetDefaultByLocationAttestationProvider(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAttestationSubscriptionResource(subscriptionResource).GetDefaultByLocationAttestationProvider(location, cancellationToken);
        }
    }
}
