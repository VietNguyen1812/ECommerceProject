import React from "react";

export default function ItemProduct(props) {
  const {product,index} = props
  return (
    <tr>
      <td>{index}</td>
      <td>{product.name}</td>
      <td>{product.description}</td>
      <td>{product.price}</td>
      <td>{product.rating}</td>
      <td>{product.imageUrl}</td>
    </tr>
  );
}
