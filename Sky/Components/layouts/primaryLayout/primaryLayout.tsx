import React from "react";
import { Box, Container } from "rebass";

import styles from "./primaryLayout.scss";
import PrimaryLayoutErrorBoundary from "./primaryLayoutErrorBoundary";

interface IProps {
  children: React.ReactNode;
}

const PrimaryLayout = ({
  children,
}: IProps) => (
  <PrimaryLayoutErrorBoundary className={styles.primaryLayout}>
    <Container>
      <Box pb={80}>
        {children}
      </Box>
    </Container>
  </PrimaryLayoutErrorBoundary>
);

export default PrimaryLayout;
