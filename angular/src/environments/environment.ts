import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Web_ECommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44398/',
    redirectUri: baseUrl,
    clientId: 'Web_ECommerce_App',
    responseType: 'code',
    scope: 'offline_access Web_ECommerce',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44345',
      rootNamespace: 'Web_ECommerce',
    },
  },
} as Environment;
