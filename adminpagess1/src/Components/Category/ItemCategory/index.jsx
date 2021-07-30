import React from 'react'

export default function ItemCategory(props) {
  const {category , index} =props
  return (
    <tr>
      <td>{index}</td>
      <td>{category.name}</td>
      <td>{category.description}</td>
      
    </tr>
  )
}
