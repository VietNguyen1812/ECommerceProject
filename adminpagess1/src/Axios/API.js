import axios from "axios";
import * as config from "../Constants/Config";

export default function API(endpoint, method, body) {
  return axios({
    method: method,
    url: `${config.API_Url}/${endpoint}`,
    data: body
  }).catch((error) => console.log(error));
}
