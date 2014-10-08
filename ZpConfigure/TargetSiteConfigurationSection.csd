<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="df415e00-5e0d-4f62-89b8-ec3d358d5449" namespace="MasterDuner.HHProjects.Csq.Highpincn.Configuration" xmlSchemaNamespace="http://www.highpin.cn" assemblyName="Highpincn.Configuration" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
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
    <configurationElement name="AnalogousCredentialsElement" inheritanceModifier="Sealed" documentation="模拟的身份认证凭据配置。">
      <attributeProperties>
        <attributeProperty name="UserName" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="userName" isReadOnly="false" documentation="设置或获取用于模拟的帐户名。">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Passphrase" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="passphrase" isReadOnly="false" documentation="设置或获取用来模拟登录的用户口令。">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElement name="AnalogousSigninElement" inheritanceModifier="Sealed" documentation="模拟登录配置。">
      <attributeProperties>
        <attributeProperty name="Enabled" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="enabled" isReadOnly="false" defaultValue="true">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/Boolean" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <elementProperties>
        <elementProperty name="AnalogousAccount" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="analogousAccount" isReadOnly="false" documentation="设置或获取模拟账户信息。">
          <type>
            <configurationElementMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/AnalogousCredentialsElement" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationElement>
    <configurationElement name="UrlResourceElement" inheritanceModifier="Sealed" documentation="卓聘网URL资源配置。">
      <attributeProperties>
        <attributeProperty name="Url" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="url" isReadOnly="false" documentation="设置或获取URL。">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Name" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="name" isReadOnly="false" documentation="设置或获取URL资源标识名称。">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="UrlResourceElementCollection" inheritanceModifier="Sealed" documentation="UrlResourceElement集合。" collectionType="BasicMap" xmlItemName="add" codeGenOptions="Indexer">
      <itemType>
        <configurationElementMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/UrlResourceElement" />
      </itemType>
    </configurationElementCollection>
    <configurationElement name="SiteResourceElement" inheritanceModifier="Sealed" documentation="站点资源配置。">
      <attributeProperties>
        <attributeProperty name="DomainName" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="domainName" isReadOnly="false" documentation="设置或获取域名称。">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <elementProperties>
        <elementProperty name="UrlResources" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="urls" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/UrlResourceElementCollection" />
          </type>
        </elementProperty>
        <elementProperty name="HomePage" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="homePage" isReadOnly="false" documentation="设置或获取卓聘网首页地址。">
          <type>
            <configurationElementMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/UrlResourceElement" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationElement>
    <configurationElement name="SessionCachingElement" inheritanceModifier="Sealed" documentation="会话缓存配置。">
      <attributeProperties>
        <attributeProperty name="CacheSlidingExpirationEnabled" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="cacheSlidingExpirationEnabled" isReadOnly="false" documentation="设置或获取是否启用滑动的会话缓存超时设置。" defaultValue="false">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/Boolean" />
          </type>
        </attributeProperty>
        <attributeProperty name="AbsoluteExpirationMinutes" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="absoluteExpirationMinutes" isReadOnly="false" documentation="设置或获取绝对超时分钟数。">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/Int32" />
          </type>
        </attributeProperty>
        <attributeProperty name="SlidingExpirationMinutes" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="slidingExpirationMinutes" isReadOnly="false" documentation="设置或获取滑动超时分钟数。" defaultValue="30">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/Int32" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationSection name="HighpinCnQueryServiceSection" inheritanceModifier="Sealed" documentation="跨站查询服务配置。" codeGenOptions="XmlnsProperty" xmlSectionName="csq.highpin.cn">
      <elementProperties>
        <elementProperty name="Authentication" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="authentication" isReadOnly="false" documentation="设置或获取卓聘网的模拟身份认证信息。">
          <type>
            <configurationElementMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/AnalogousSigninElement" />
          </type>
        </elementProperty>
        <elementProperty name="Resources" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="resources" isReadOnly="false" documentation="设置或获取卓聘网的站点资源。">
          <type>
            <configurationElementMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/SiteResourceElement" />
          </type>
        </elementProperty>
        <elementProperty name="SessionCaching" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="sessionCaching" isReadOnly="false" documentation="设置或获取会话缓存设置。">
          <type>
            <configurationElementMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/SessionCachingElement" />
          </type>
        </elementProperty>
        <elementProperty name="ValidatingCodeTempDir" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="validatingCodeTempDir" isReadOnly="false" documentation="设置或获取验证码临时文件目录路径。">
          <type>
            <configurationElementMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/ValidatingCodeTemporaryDirectoryElement" />
          </type>
        </elementProperty>
        <elementProperty name="LegalValidatingCodeSequence" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="legalValidatingCodeSequence" isReadOnly="false" documentation="设置或获取合法的验证码字符序列。">
          <type>
            <configurationElementMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/LegalCharsequenceElement" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElement name="ValidatingCodeTemporaryDirectoryElement" inheritanceModifier="Sealed" documentation="验证码临时目录配置。">
      <attributeProperties>
        <attributeProperty name="Path" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="path" isReadOnly="false" documentation="设置或获取临时文件路径。">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElement name="LegalCharsequenceElement" inheritanceModifier="Sealed" documentation="合法的验证码字符序列配置。">
      <attributeProperties>
        <attributeProperty name="Chars" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="chars" isReadOnly="false" documentation="设置或获取字符串序列。">
          <type>
            <externalTypeMoniker name="/df415e00-5e0d-4f62-89b8-ec3d358d5449/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>