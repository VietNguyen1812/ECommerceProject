import React, { createContext, useEffect, useState } from 'react';

import {GetProducts ,PostProducts,PutProducts,DeleteProducts} from "../Services/productAPI";
import { GetCategory } from "../Services/categoryAPI";

export const ProductContext = createContext({});