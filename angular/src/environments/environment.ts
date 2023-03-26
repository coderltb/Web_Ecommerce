import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Web_ECommerce Admin',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:5000/',
    redirectUri: baseUrl,
    clientId: 'Web_ECommerce_Admin',
    dummyClientSecret: '1q2w3e',
    responseType: 'code',
    scope: 'offline_access Web_ECommerce.Admin',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:5001',
      rootNamespace: 'Web_ECommerce.Admin',
    },
  },
} as Environment;
