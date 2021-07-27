import React, { createContext, useEffect, useState } from "react";
import {
  GetCategory,
  PostCategory,
  PutCategory,
  DeleteCategory,
} from "../Services/categoryAPI";

export const CategoryContext = createContext({});

const CategoryContextProvider = ({ children }) => {
  const [categoryItems, setCategoryItems] = useState([]);

  const postCategory = (formData) => {
    (async () => {
      await PostCategory(formData);
      setCategoryItems(await GetCategory());
    })();
  };
  
  const putCategory = (id, formData) => {
    (async () => {
      await PutCategory(id, formData);
      setCategoryItems(await GetCategory());
    })();
  };

  const deleteCategory = (id) => {
    (async () => {
      await DeleteCategory(id);
      setCategoryItems(await GetCategory());
    })();
  };

  useEffect(() => {
    (async () => {
      setCategoryItems(await GetCategory());
    })();
  }, []);

  return (
    <CategoryContext.Provider
      value={{
        categoryItems,
        postCategory,
        putCategory,
        deleteCategory,
      }}
    >
      {children}
    </CategoryContext.Provider>
  );
};
export default CategoryContextProvider;