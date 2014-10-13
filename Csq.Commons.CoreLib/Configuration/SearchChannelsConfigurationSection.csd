﻿<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78" namespace="MasterDuner.Cooperations.Csq.Commons.Configuration" xmlSchemaNamespace="urn:MasterDuner@Yeah.net" assemblyName="Csq.Wsi.Core" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationElement name="EntryPointElement" inheritanceModifier="Sealed" documentation="指定搜索渠道入口程序类型配置。">
      <attributeProperties>
        <attributeProperty name="Enabled" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="enabled" isReadOnly="false" documentation="设置或获取是否启用此入口点。" defaultValue="true">
          <type>
            <externalTypeMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/Boolean" />
          </type>
        </attributeProperty>
        <attributeProperty name="Type" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="type" isReadOnly="false" documentation="设置或获取此入口点类型的完全限定名称。">
          <type>
            <externalTypeMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <elementProperties>
        <elementProperty name="PrivateConfig" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="privateConfig" isReadOnly="false" documentation="设置或获取私有配置。">
          <type>
            <configurationElementMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/PrivateConfigurationElement" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationElement>
    <configurationElement name="UrlElement" inheritanceModifier="Sealed" documentation="URL地址配置。">
      <attributeProperties>
        <attributeProperty name="Url" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="url" isReadOnly="false" documentation="设置或获取URL。">
          <type>
            <externalTypeMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElement name="SearchChannelElement" inheritanceModifier="Sealed" documentation="搜索渠道配置。">
      <attributeProperties>
        <attributeProperty name="ID" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="id" isReadOnly="false" documentation="设置或获取渠道标记值。" defaultValue="1024">
          <type>
            <externalTypeMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/Int32" />
          </type>
        </attributeProperty>
        <attributeProperty name="Description" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="description" isReadOnly="false" documentation="设置或获取描述信息。">
          <type>
            <externalTypeMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <elementProperties>
        <elementProperty name="EntryPoint" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="entryPoint" isReadOnly="false" documentation="设置或获取入口点配置。">
          <type>
            <configurationElementMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/EntryPointElement" />
          </type>
        </elementProperty>
        <elementProperty name="HomePage" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="homePage" isReadOnly="false" documentation="设置或获取首页URL配置。">
          <type>
            <configurationElementMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/UrlElement" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationElement>
    <configurationElement name="PrivateConfigurationElement" inheritanceModifier="Sealed" documentation="私有配置文件配置。">
      <attributeProperties>
        <attributeProperty name="HasPrivateConfigurationFile" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="hasPrivateConfigurationFile" isReadOnly="false" documentation="设置或获取是否含有私有配置。" defaultValue="false">
          <type>
            <externalTypeMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/Boolean" />
          </type>
        </attributeProperty>
        <attributeProperty name="PrivateConfigurationFileName" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="privateConfigurationFileName" isReadOnly="false" documentation="设置或获取私有配置文件名称。">
          <type>
            <externalTypeMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="SearchChannelElementCollection" inheritanceModifier="Sealed" documentation="SearchChannelElement配置集合。" collectionType="BasicMap" xmlItemName="add" codeGenOptions="Indexer">
      <itemType>
        <configurationElementMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/SearchChannelElement" />
      </itemType>
    </configurationElementCollection>
    <configurationSection name="SearchChannelSection" inheritanceModifier="Sealed" documentation="搜索渠道配置。" codeGenOptions="XmlnsProperty" xmlSectionName="csq.channels">
      <elementProperties>
        <elementProperty name="Channels" isRequired="false" isKey="false" isDefaultCollection="true" xmlName="" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/68edb1b6-8ee7-42d8-9acc-6c9f8cfd3c78/SearchChannelElementCollection" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>