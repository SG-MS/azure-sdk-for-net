// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// The configuration for Compute Nodes in a Pool based on the Azure Virtual
    /// Machines infrastructure.
    /// </summary>
    public partial class VirtualMachineConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineConfiguration"/>. </summary>
        /// <param name="imageReference"> A reference to the Azure Virtual Machines Marketplace Image or the custom Virtual Machine Image to use. </param>
        /// <param name="nodeAgentSkuId"> The SKU of the Batch Compute Node agent to be provisioned on Compute Nodes in the Pool. The Batch Compute Node agent is a program that runs on each Compute Node in the Pool, and provides the command-and-control interface between the Compute Node and the Batch service. There are different implementations of the Compute Node agent, known as SKUs, for different operating systems. You must specify a Compute Node agent SKU which matches the selected Image reference. To get the list of supported Compute Node agent SKUs along with their list of verified Image references, see the 'List supported Compute Node agent SKUs' operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imageReference"/> or <paramref name="nodeAgentSkuId"/> is null. </exception>
        public VirtualMachineConfiguration(BatchVmImageReference imageReference, string nodeAgentSkuId)
        {
            Argument.AssertNotNull(imageReference, nameof(imageReference));
            Argument.AssertNotNull(nodeAgentSkuId, nameof(nodeAgentSkuId));

            ImageReference = imageReference;
            NodeAgentSkuId = nodeAgentSkuId;
            DataDisks = new ChangeTrackingList<DataDisk>();
            Extensions = new ChangeTrackingList<VMExtension>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineConfiguration"/>. </summary>
        /// <param name="imageReference"> A reference to the Azure Virtual Machines Marketplace Image or the custom Virtual Machine Image to use. </param>
        /// <param name="nodeAgentSkuId"> The SKU of the Batch Compute Node agent to be provisioned on Compute Nodes in the Pool. The Batch Compute Node agent is a program that runs on each Compute Node in the Pool, and provides the command-and-control interface between the Compute Node and the Batch service. There are different implementations of the Compute Node agent, known as SKUs, for different operating systems. You must specify a Compute Node agent SKU which matches the selected Image reference. To get the list of supported Compute Node agent SKUs along with their list of verified Image references, see the 'List supported Compute Node agent SKUs' operation. </param>
        /// <param name="windowsConfiguration"> Windows operating system settings on the virtual machine. This property must not be specified if the imageReference property specifies a Linux OS Image. </param>
        /// <param name="dataDisks"> The configuration for data disks attached to the Compute Nodes in the Pool. This property must be specified if the Compute Nodes in the Pool need to have empty data disks attached to them. This cannot be updated. Each Compute Node gets its own disk (the disk is not a file share). Existing disks cannot be attached, each attached disk is empty. When the Compute Node is removed from the Pool, the disk and all data associated with it is also deleted. The disk is not formatted after being attached, it must be formatted before use - for more information see https://learn.microsoft.com/azure/virtual-machines/linux/classic/attach-disk#initialize-a-new-data-disk-in-linux and https://learn.microsoft.com/azure/virtual-machines/windows/attach-disk-ps#add-an-empty-data-disk-to-a-virtual-machine. </param>
        /// <param name="licenseType">
        /// This only applies to Images that contain the Windows operating system, and
        /// should only be used when you hold valid on-premises licenses for the Compute
        /// Nodes which will be deployed. If omitted, no on-premises licensing discount is
        /// applied. Values are:
        ///
        ///  Windows_Server - The on-premises license is for Windows
        /// Server.
        ///  Windows_Client - The on-premises license is for Windows Client.
        ///
        /// </param>
        /// <param name="containerConfiguration"> The container configuration for the Pool. If specified, setup is performed on each Compute Node in the Pool to allow Tasks to run in containers. All regular Tasks and Job manager Tasks run on this Pool must specify the containerSettings property, and all other Tasks may specify it. </param>
        /// <param name="diskEncryptionConfiguration"> The disk encryption configuration for the pool. If specified, encryption is performed on each node in the pool during node provisioning. </param>
        /// <param name="nodePlacementConfiguration"> The node placement configuration for the pool. This configuration will specify rules on how nodes in the pool will be physically allocated. </param>
        /// <param name="extensions"> The virtual machine extension for the pool. If specified, the extensions mentioned in this configuration will be installed on each node. </param>
        /// <param name="osDisk"> Settings for the operating system disk of the Virtual Machine. </param>
        /// <param name="securityProfile"> Specifies the security profile settings for the virtual machine or virtual machine scale set. </param>
        /// <param name="serviceArtifactReference"> Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when using 'latest' image version. The service artifact reference id in the form of /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineConfiguration(BatchVmImageReference imageReference, string nodeAgentSkuId, WindowsConfiguration windowsConfiguration, IList<DataDisk> dataDisks, string licenseType, BatchContainerConfiguration containerConfiguration, DiskEncryptionConfiguration diskEncryptionConfiguration, BatchNodePlacementConfiguration nodePlacementConfiguration, IList<VMExtension> extensions, BatchOsDisk osDisk, SecurityProfile securityProfile, ServiceArtifactReference serviceArtifactReference, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ImageReference = imageReference;
            NodeAgentSkuId = nodeAgentSkuId;
            WindowsConfiguration = windowsConfiguration;
            DataDisks = dataDisks;
            LicenseType = licenseType;
            ContainerConfiguration = containerConfiguration;
            DiskEncryptionConfiguration = diskEncryptionConfiguration;
            NodePlacementConfiguration = nodePlacementConfiguration;
            Extensions = extensions;
            OsDisk = osDisk;
            SecurityProfile = securityProfile;
            ServiceArtifactReference = serviceArtifactReference;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineConfiguration"/> for deserialization. </summary>
        internal VirtualMachineConfiguration()
        {
        }

        /// <summary> A reference to the Azure Virtual Machines Marketplace Image or the custom Virtual Machine Image to use. </summary>
        public BatchVmImageReference ImageReference { get; set; }
        /// <summary> The SKU of the Batch Compute Node agent to be provisioned on Compute Nodes in the Pool. The Batch Compute Node agent is a program that runs on each Compute Node in the Pool, and provides the command-and-control interface between the Compute Node and the Batch service. There are different implementations of the Compute Node agent, known as SKUs, for different operating systems. You must specify a Compute Node agent SKU which matches the selected Image reference. To get the list of supported Compute Node agent SKUs along with their list of verified Image references, see the 'List supported Compute Node agent SKUs' operation. </summary>
        public string NodeAgentSkuId { get; set; }
        /// <summary> Windows operating system settings on the virtual machine. This property must not be specified if the imageReference property specifies a Linux OS Image. </summary>
        public WindowsConfiguration WindowsConfiguration { get; set; }
        /// <summary> The configuration for data disks attached to the Compute Nodes in the Pool. This property must be specified if the Compute Nodes in the Pool need to have empty data disks attached to them. This cannot be updated. Each Compute Node gets its own disk (the disk is not a file share). Existing disks cannot be attached, each attached disk is empty. When the Compute Node is removed from the Pool, the disk and all data associated with it is also deleted. The disk is not formatted after being attached, it must be formatted before use - for more information see https://learn.microsoft.com/azure/virtual-machines/linux/classic/attach-disk#initialize-a-new-data-disk-in-linux and https://learn.microsoft.com/azure/virtual-machines/windows/attach-disk-ps#add-an-empty-data-disk-to-a-virtual-machine. </summary>
        public IList<DataDisk> DataDisks { get; }
        /// <summary>
        /// This only applies to Images that contain the Windows operating system, and
        /// should only be used when you hold valid on-premises licenses for the Compute
        /// Nodes which will be deployed. If omitted, no on-premises licensing discount is
        /// applied. Values are:
        ///
        ///  Windows_Server - The on-premises license is for Windows
        /// Server.
        ///  Windows_Client - The on-premises license is for Windows Client.
        ///
        /// </summary>
        public string LicenseType { get; set; }
        /// <summary> The container configuration for the Pool. If specified, setup is performed on each Compute Node in the Pool to allow Tasks to run in containers. All regular Tasks and Job manager Tasks run on this Pool must specify the containerSettings property, and all other Tasks may specify it. </summary>
        public BatchContainerConfiguration ContainerConfiguration { get; set; }
        /// <summary> The disk encryption configuration for the pool. If specified, encryption is performed on each node in the pool during node provisioning. </summary>
        public DiskEncryptionConfiguration DiskEncryptionConfiguration { get; set; }
        /// <summary> The node placement configuration for the pool. This configuration will specify rules on how nodes in the pool will be physically allocated. </summary>
        public BatchNodePlacementConfiguration NodePlacementConfiguration { get; set; }
        /// <summary> The virtual machine extension for the pool. If specified, the extensions mentioned in this configuration will be installed on each node. </summary>
        public IList<VMExtension> Extensions { get; }
        /// <summary> Settings for the operating system disk of the Virtual Machine. </summary>
        public BatchOsDisk OsDisk { get; set; }
        /// <summary> Specifies the security profile settings for the virtual machine or virtual machine scale set. </summary>
        public SecurityProfile SecurityProfile { get; set; }
        /// <summary> Specifies the service artifact reference id used to set same image version for all virtual machines in the scale set when using 'latest' image version. The service artifact reference id in the form of /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}. </summary>
        public ServiceArtifactReference ServiceArtifactReference { get; set; }
    }
}
