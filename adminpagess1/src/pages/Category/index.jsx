import React, { useEffect } from "react";
import ListCategory from "../../Components/Category/ListCategory";
import { useSelector, useDispatch } from "react-redux";
import ItemProduct from "../../Components/Product/ItemProduct";
import API from "../../Axios/API";

export default function Category() {
  const Category = useSelector((state) => state.Category);
  const dispatch = useDispatch();
  const fetchCategoryApi = async () => {
    try {
      const rest = await API("Category", "GET", null);
      dispatch({ type: "fetchCategory", Category: rest.data });
    } catch (err) {
      console.log(err);
    }
  };
  useEffect(() => {
    fetchCategoryApi();
  }, []);
  console.log(Category);
  const showAllCategory = () => {
    let result = null;
    if (Category.length > 0) {
      result = Category.map((category, index) => {
        return <ItemProduct key={index} product={category} index={index} />;
      });
    }
    return result;
  };

  return (
    <>
      <div className="card mb-4">
        <div className="card-header">
          <i className="fas fa-table me-1" />
          DataTable Example
        </div>
        <ListCategory>{showAllCategory()}</ListCategory>
      </div>
    </>
  );
}
