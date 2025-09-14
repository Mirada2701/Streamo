import axios, { AxiosError } from 'axios';
import { getToken } from './tokenService';
import { handleError } from '../common/handleError';
import {APP_CONFIG} from "../env";

const http_api = axios.create({
  baseURL: APP_CONFIG.API_URL,
  headers: {
    'Content-Type': 'application/json',
    Authorization: `${getToken()}`,
  },
 
});

http_api.interceptors.response.use(
  (responce) => responce,
  (error: AxiosError) => {
    console.log('catched', error);
    switch (error.response?.status) {
      case 401: {
        handleError('Please, sign in to act');
        break;
      }
      case 403: {
        handleError('Forbidden action');
        break;
      }
      case 422: {
        console.log('422', error);
        handleError(error);
        break;
      }
    }
    if (error.code == 'ERR_NETWORK') {
      window.location.href = '/auth/signin';
    }
    return Promise.reject(error);
  },
);

export default http_api;
