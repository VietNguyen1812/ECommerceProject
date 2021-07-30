import * as types from "../Constants/Actiontype";

let intialState = [];

const Product = (state = intialState, action) => {
  switch (action.type) {
    case types.fetchProduct:
      return action.Product;
    default:
      return state;
  }
};
export default Product;
