import  axios , {AxiosInstance ,AxiosRequestConfig } from "axios";
import { Backend_url } from "../config";

const config : AxiosRequestConfig = {
  baseURL : Backend_url
}

class RequestService {
  public axios : AxiosInstance;

  constructor() {
    this.axios = axios.create(config);
  }
  
}

export default new RequestService();