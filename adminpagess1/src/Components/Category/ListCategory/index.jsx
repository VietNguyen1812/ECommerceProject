import React from 'react'

export default function ListCategory(props) {
  return (
    <table id="datatablesSimple">
      <thead>
        <tr>
          <th>Id</th>
          <th>Name</th>
          <th>Description</th>
        </tr>
      </thead>

      <tbody>{props.children}</tbody>
    </table>
  )
}
