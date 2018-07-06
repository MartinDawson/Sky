import { makeRouteConfig, Route } from "found";
import React from "react";

import { routeConfig as primaryLayoutRouteConfig } from "../../layouts/primaryLayout/primaryLayoutContainer";

export default makeRouteConfig(
  <Route path="/" {...primaryLayoutRouteConfig}>
    <Route />
  </Route>,
);
