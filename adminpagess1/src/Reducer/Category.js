import * as types from "../Constants/Actiontype";

let intialState = [];

const Category = (state = intialState, action) => {
  switch (action.type) {
    case types.fetchCategory:
      return action.Category;
    default:
      return state;
  }
};
export default Category;