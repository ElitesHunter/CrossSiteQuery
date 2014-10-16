<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="74673cc5-848c-4d40-9cff-10412cc8a70d" namespace="MasterDuner.Cooperations.Csq.Channels.Configuration" xmlSchemaNamespace="urn:MasterDuner@Yeah.net" assemblyName="Csq.Wsi.Channels.HighpinCn" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
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
    <configurationElement name="HPActionUrlElement" inheritanceModifier="Sealed" documentation="智联卓聘网页面URL配置。">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="name" isReadOnly="false" documentation="设置或获取URL标识名称。">
          <type>
            <externalTypeMoniker name="/74673cc5-848c-4d40-9cff-10412cc8a70d/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="BaseUrl" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="baseUrl" isReadOnly="false" documentation="设置或获取基础URL。">
          <type>
            <externalTypeMoniker name="/74673cc5-848c-4d40-9cff-10412cc8a70d/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="HPActionUrlElementCollection" inheritanceModifier="Sealed" documentation="HPActionUrlElement配置集合。" collectionType="BasicMap" xmlItemName="add" codeGenOptions="Indexer">
      <itemType>
        <configurationElementMoniker name="/74673cc5-848c-4d40-9cff-10412cc8a70d/HPActionUrlElement" />
      </itemType>
    </configurationElementCollection>
    <configurationSection name="HPSection" inheritanceModifier="Sealed" documentation="智联卓聘网私有配置。" codeGenOptions="XmlnsProperty" xmlSectionName="www.highpin.cn">
      <elementProperties>
        <elementProperty name="ActionUrls" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="actionUrls" isReadOnly="false" documentation="设置或获取智联卓聘网的URL配置。">
          <type>
            <configurationElementCollectionMoniker name="/74673cc5-848c-4d40-9cff-10412cc8a70d/HPActionUrlElementCollection" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>