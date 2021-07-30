import React from "react";

export default function ListProduct(props) {
  return (
    <table id="datatablesSimple">
      <thead>
        <tr>
          <th>Id</th>
          <th>Name</th>
          <th>Description</th>
          <th>Price</th>
          <th>Rating</th>
          <th>ImageUrl</th>
        </tr>
      </thead>

      <tbody>{props.children}</tbody>
    </table>
  );
}
