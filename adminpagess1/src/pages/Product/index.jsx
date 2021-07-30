import React, { useEffect } from "react";
import ListProduct from "../../Components/Product/ListProduct";
import { useSelector, useDispatch } from "react-redux";
import ItemProduct from "../../Components/Product/ItemProduct/";
import API from "../../Axios/API";

export default function Product() {
  const Products = useSelector((state) => state.Product);
  const dispatch = useDispatch();
  const fetchProductApi = async () => {
    try {
      const rest = await API("Products", "GET", null);
      dispatch({ type: "fetchProduct", Product: rest.data });
    } catch (err) {
      console.log(err);
    }
  };
  // PRODUCT
  // const rest = await API("Products/", "POST", product);
  // const rest = await API("Product/${product.id}", "POST", product);
  useEffect(() => {
    fetchProductApi();
  }, []);
  console.log(Products);
  const showAllProduct = () => {
    let result = null;
    if (Products.length > 0) {
      result = Products.map((product, index) => {
        return <ItemProduct key={index} product={product} index={index} />;
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
          <div>
            <ListProduct>{showAllProduct()}</ListProduct>
          </div>
        </div>
      </div>
    </>
  );
}
