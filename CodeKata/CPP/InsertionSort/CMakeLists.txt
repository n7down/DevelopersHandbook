cmake_minimum_required(VERSION 3.7)

set(CMAKE_EXPORT_COMPILE_COMMANDS ON)

set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin)

cmake_policy(SET CMP0048 NEW)
project(my_gtest_pkgconfig VERSION 0.0.1 LANGUAGES CXX)

find_package(PkgConfig)
pkg_search_module(GTEST REQUIRED gtest_main)

include_directories(src)

file(GLOB HEADERS src/*.h)
file(GLOB SOURCES src/*.cpp)
file(GLOB TESTS test/*.cc)

add_executable(all_tests ${HEADERS} ${SOURCES} ${TESTS})
target_link_libraries(all_tests ${GTEST_LDFLAGS})
target_compile_options(all_tests PUBLIC ${GTEST_CFLAGS})
include(CTest)
add_test(TEST all_tests COMMAND all_tests)
