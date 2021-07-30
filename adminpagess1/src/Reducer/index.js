import { combineReducers } from "redux";
import Product from "./Product"
import Category from "./Category"

const myReducers = combineReducers({
  Product,
  Category
})
export default myReducers;
