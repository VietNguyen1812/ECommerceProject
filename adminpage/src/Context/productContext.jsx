import React, { createContext, useEffect, useState } from 'react';

import {GetProducts ,PostProducts,PutProducts,DeleteProducts} from "../Services/productAPI";
import { GetCategory } from "../Services/categoryAPI";

export const ProductContext = createContext({});

const ProductContextProvider = ({children}) =>{
  const [productItems , setProductItems] = useState([]);
  const [categoryItems, setCategoryItems] = useState([]);
  
  const postProduct = (formData) =>{
    (async () => {
      await PostProducts (formData);
      setProductItems(await GetProducts());
    })();
  };

  const putProduct = (id, formData) => {
    (async () => {
      await PutProducts(id,formData);
      setProductItems(await GetProducts());
    })();
  };

  const deleteProduct =(id) => {
    (async () => {
      await DeleteProducts(id);
      setProductItems(await GetProducts());
    })();
  };
  useEffect(() => {
    (async () => {
      setProductItems(await GetProducts());
      setCategoryItems(await GetCategory());
    })();
  }, []);
  return(
    <ProductContext.Provider value ={{
      productItems,
      categoryItems,
      postProduct,
      putProduct,
      deleteProduct
    }}>
      {children}
      </ProductContext.Provider>
  )
}

export default ProductContextProvider;